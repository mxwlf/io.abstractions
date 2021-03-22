using System.Collections;
using System.Collections.Generic;

namespace mxwlf.io.filesystem
{
    public interface IContainer : IContainerContents, IEnumerable<IContainerContents>
    {
        public IEnumerable<IContainerContents> Contents { get; }
    }
}