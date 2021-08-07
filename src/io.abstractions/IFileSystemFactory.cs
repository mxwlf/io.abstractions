namespace Mxwlf.IO.Abstractions
{
    public interface IFileSystemFactory
    {
        IFileSystemProxy GetFileSystem(string uri);
    }
}