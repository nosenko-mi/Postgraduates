using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.utils.file.Exporter
{
    internal interface IExporter
    {
        void EportTable(DataTable table, string path);
    }
}
