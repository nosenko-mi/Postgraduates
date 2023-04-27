using Postgraduates.model;
using Postgraduates.utils.Converter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Postgraduates.repository
{
    internal class PostgradRepository
    {
        public string FilePath { get; set; }
        public PostgradRepository(string filePath) { FilePath = filePath; }
        public PostgradRepository() { FilePath = ""; }

        public IEnumerable<Postgrad>? GetAll()
        {
            return null;
        }

        public IEnumerable<Postgrad>? RunQuery(string[] queryParams)
        {
            var context = new QueryContext();
            if (queryParams[0].StartsWith('>'))
            {
                context.SetStrategy(new QueryGreater());
            }
            else if (queryParams[0].StartsWith('<'))
            {
                context.SetStrategy(new QuerySmaller());
            }
            else
            {
                context.SetStrategy(new QueryEqual());
            }

            var list = context.Execute(queryParams, FilePath);
            return list;
        }

    }
}
