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

        private QueryContext _context;

        public PostgradRepository(string filePath)
        { 
            FilePath = filePath;
            _context = new QueryContext(); 
        }
        public PostgradRepository() 
        { 
            FilePath = "";
            _context = new QueryContext();
        }

        public IEnumerable<Postgrad>? GetAll()
        {
            return null;
        }

        public IEnumerable<Postgrad>? RunQuery(string[] queryParams)
        {
            //context = new QueryContext();
            if (queryParams[0].StartsWith('>'))
            {
                _context.SetStrategy(new QueryGreater());
            }
            else if (queryParams[0].StartsWith('<'))
            {
                _context.SetStrategy(new QuerySmaller());
            }
            else
            {
                _context.SetStrategy(new QueryEqual());
            }

            var list = _context.Execute(queryParams, FilePath);
            return list;
        }

    }
}
