using Postgraduates.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.repository
{
    internal class QueryContext
    {
        private IQueryStrategy _strategy;

        public void SetStrategy(IQueryStrategy strategy)
        {
            _strategy = strategy;
        }

        public IEnumerable<Postgrad> Execute(string[] queryParams, string filePath)
        {
            return _strategy.RunQuery(queryParams, filePath);
        }
    }
}
