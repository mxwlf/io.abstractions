using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace mxwlf.io.filesystem
{
    public abstract class FileSystemGateway : IFileSystemGateway
    {
        public async Task<IEnumerable<IContainerContents>> GetContainerContents(string containerUri)
        {
            if (await isValid(containerUri) == false)
            {
                throw new ArgumentException("The provided container Uri is not valid.", nameof(containerUri));
            }

            foreach (Directory.EnumerateDirectories(containerUri))
            {
                
            }
        }

        public Task<bool> isValid(string containerUri)
        {
            if (false == Directory.Exists(containerUri))
            {
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }
    }
}