using Postgraduates.utils.file.FileFactory;

namespace Postgraduates.utils.file.FileReader
{
    internal class HTMLFileReader : IFileReader
    {
        public string ReadFile(string path)
        {
            var file = new HTMLFile();
            return file.Read(path);
        }
    }
}
