using System;

namespace mxwlf.io.filesystem
{
    public abstract class File
    {
        private IFileSystemGateway _fileSystemGateway;

        protected File(IFileSystemGateway fileSystemGateway)
        {
            _fileSystemGateway = fileSystemGateway ?? throw new ArgumentNullException(nameof(fileSystemGateway));
        }
        
        
    }
}