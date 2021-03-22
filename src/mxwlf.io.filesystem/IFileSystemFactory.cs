namespace mxwlf.io.filesystem
{
    public interface IFileSystemFactory
    {
        IFileSystemGateway GetFileSystem(string url);
    }
}