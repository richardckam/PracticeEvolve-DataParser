namespace Kamputing.DataParser.IO
{
    public interface IFileReader
    {
        void SetFilePath(string filePath);
        string ReadFileContents();
    }
}
