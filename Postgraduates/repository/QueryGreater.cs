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
    internal class QueryGreater : IQueryStrategy
    {
        public IEnumerable<Postgrad> RunQuery(string[] queryParams, string filePath)
        {
            XDocument xml = XDocument.Load(filePath); // Load the XML document
            IEnumerable<XElement> query = new List<XElement>();
            IEnumerable<Postgrad> list = new List<Postgrad>();

            int val;
            try
            {
                val = int.Parse(queryParams[0].Substring(1, queryParams[0].Length - 1));
                query =
                    from postgrad in xml.Descendants("Postgrad")
                    where ParseString(postgrad.Element(queryParams[1])) > val
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

        private int ParseString(XElement element)
        {
            try
            {
                return int.Parse(element.Value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }
    }
}
