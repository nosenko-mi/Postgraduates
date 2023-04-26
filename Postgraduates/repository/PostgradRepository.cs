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
            XDocument xml = XDocument.Load(FilePath); // Load the XML document
            IEnumerable<XElement> query = new List<XElement>();
            IEnumerable<Postgrad> list = new List<Postgrad>();

            int val;
            if (queryParams[0].StartsWith('>'))
            {
                try
                {
                    val = int.Parse(queryParams[0].Substring(1, queryParams[0].Length - 1));
                    query =
                        from postgrad in xml.Descendants("Postgrad")
                        where (int)postgrad.Element(queryParams[1]) > val
                        select postgrad;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (queryParams[0].StartsWith('<'))
            {
                try
                {
                    val = int.Parse(queryParams[0].Substring(1, queryParams[0].Length-1));
                    query =
                        from postgrad in xml.Descendants("Postgrad")
                        where (int)postgrad.Element(queryParams[1]) < val
                        select postgrad;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    query =
                        from postgrad in xml.Descendants("Postgrad")
                        where (string)postgrad.Element(queryParams[1]) == queryParams[0]
                        select postgrad;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            var converter = new PostgradConverter();
            list = converter.ToList(query);

            return list;
        }
    }
}
