using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.utils.file.FileFactory
{
    public abstract class PostgradFile
    {
        public string Text { get; set; }

        public PostgradFile()
        {
            Text = string.Empty;
        }

        public PostgradFile(string text)
        {
            Text = text;
        }
        public abstract void Save(string path);

        public abstract string Read(string path);
    }
}
