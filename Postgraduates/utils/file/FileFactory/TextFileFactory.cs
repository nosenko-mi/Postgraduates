using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.utils.file.FileFactory
{
    class TextFileFactory : FileFactory
    {
        public override PostgradFile FactoryMethod(string content)
        {
            return new TextFile(content);
        }
    }
}
