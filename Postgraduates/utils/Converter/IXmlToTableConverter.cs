using Postgraduates.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.utils.Converter
{
    internal interface IXmlToTableConverter
    {
        public DataTable ToDataTable(IEnumerable<Postgrad> list);
        public DataTable ToDataTable(List<IXmlConvertible> list);
    }
}
