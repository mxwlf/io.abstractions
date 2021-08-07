using System.Collections;
using System.Collections.Generic;

namespace Mxwlf.IO.Abstractions
{
    public interface IDirectory : IDirectoryContents, IEnumerable<IDirectoryContents>
    {
        public IEnumerable<IDirectoryContents> Contents { get; }
    }
}