using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mxwlf.io.filesystem
{
    public interface IFileSystemGateway
    {
        Task<IEnumerable<IContainerContents>> GetContainerContents(string containerUri);

        Task<bool> isValid(string containerUri);
    }
}