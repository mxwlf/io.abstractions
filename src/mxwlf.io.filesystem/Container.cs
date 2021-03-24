using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxwlf.io.filesystem
{
    public abstract class Container : IContainer
    {
        private IEnumerable<IContainerContents> _contents;
        private readonly IFileSystemGateway _fileSystemGateway;
        private readonly string _containerUri;
        
        
        
        protected Container(IFileSystemGateway fileSystemGateway, string containerUri)
        {
            _fileSystemGateway = fileSystemGateway ?? throw new ArgumentNullException(nameof(fileSystemGateway));
            _containerUri = containerUri;
        }
        

        public IEnumerator<IContainerContents> GetEnumerator() => Contents.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Contents.GetEnumerator();

        private async Task<IEnumerable<IContainerContents>> GetContents(IFileSystemGateway fileSystemGateway, string containerUri)
        {
             return await fileSystemGateway.GetContainerContents(containerUri).ConfigureAwait(false);
        }

        public IEnumerable<IContainerContents> Contents
        {
            get { return _contents ??= GetContents(this._fileSystemGateway, this._containerUri).Result; }
        }
    }
}