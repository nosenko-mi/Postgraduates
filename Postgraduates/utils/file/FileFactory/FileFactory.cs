using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.utils.file.FileFactory
{
    public abstract class FileFactory
    {
        public abstract PostgradFile FactoryMethod(string content);

        public void SaveFile(string path, string content)
        {
            var file = FactoryMethod(content);
            file.Save(path);
        }
    }
}
