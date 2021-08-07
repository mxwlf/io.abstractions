using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mxwlf.IO.Abstractions
{
    public interface IFileSystemProxy
    {
        IDirectory GetRoot();

        Task<IEnumerable<IDirectoryContents>> GetDirectoryContents(string uri);
    }
}