namespace Postgraduates.utils.file.FileReader
{
    internal class FileReader
    {
        private IFileReader _reader;
        public FileReader(IFileReader fileReader) { _reader = fileReader; }

        public string ReadFile(string path)
        {
            return _reader.ReadFile(path);
        }
    }
}
