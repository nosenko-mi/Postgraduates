using Postgraduates.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.repository
{
    internal interface IQueryStrategy
    {
        public IEnumerable<Postgrad> RunQuery(string[] queryParams, string filePath);
    }
}
