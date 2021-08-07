

namespace Mxwlf.IO.Abstractions
{
    public abstract class FileImproved
    {
        private readonly IFileProxy _fileProxy;
        private readonly string _uri;

        protected FileImproved(IFileProxy fileProxy, string uri)
        {
            _fileProxy = fileProxy;
            _uri = uri;
        }
    }
}