

using Postgraduates.utils.file.FileFactory;

namespace Postgraduates.utils.file.FileReader
{
    internal class TextFileReader : IFileReader
    {
        public string ReadFile(string path)
        {
            var file = new TextFile();
            return file.Read(path);
        }
    }
}
