using Postgraduates.model;
using Postgraduates.utils.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Postgraduates.repository
{
    internal class QueryEqual: IQueryStrategy
    {
        public IEnumerable<Postgrad> RunQuery(string[] queryParams, string filePath)
        {
            XDocument xml = XDocument.Load(filePath); // Load the XML document
            IEnumerable<XElement> query = new List<XElement>();
            IEnumerable<Postgrad> list = new List<Postgrad>();

            try
            {
                query =
                    from postgrad in xml.Descendants("Postgrad")
                    where (string)postgrad.Element(queryParams[1]) == queryParams[0]
                    select postgrad;

                var converter = new PostgradConverter();
                list = converter.ToList(query);

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }

        }
    }
}
