

using Postgraduates.utils.file.FileFactory;

namespace Postgraduates.utils.file.FileReader
{
    internal class XmlFileReader : IFileReader
    {
        public string ReadFile(string path)
        {
            var file = new XmlFile();
            return file.Read(path);
        }
    }
}
