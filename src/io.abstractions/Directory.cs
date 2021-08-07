using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mxwlf.IO.Abstractions
{
    public abstract class Directory : IDirectory
    {
        private IEnumerable<IDirectoryContents> _contents;
        private readonly IFileSystemProxy _fileSystemProxy;
        private readonly string _directoryUri;
        
        protected Directory(IFileSystemProxy fileSystemGateway, string directoryUri)
        {
            _fileSystemProxy = fileSystemGateway ?? throw new ArgumentNullException(nameof(fileSystemGateway));
            _directoryUri = directoryUri;
        }
        
        public IEnumerator<IDirectoryContents> GetEnumerator() => Contents.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Contents.GetEnumerator();

        private static async Task<IEnumerable<IDirectoryContents>> GetContents(IFileSystemProxy fileSystemGateway, string containerUri)
        {
             return await fileSystemGateway.GetDirectoryContents(containerUri).ConfigureAwait(false);
        }

        public IEnumerable<IDirectoryContents> Contents
        {
            get { return _contents ??= GetContents(_fileSystemProxy, _directoryUri).Result; }
        }
    }
}