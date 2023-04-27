using Postgraduates.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Postgraduates.utils.Converter
{
    internal class PostgradConverter : IXmlToTableConverter
    {
        public DataTable ToDataTable(IEnumerable<Postgrad> list)
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Faculty", typeof(string));
            dt.Columns.Add("Department", typeof(string));
            dt.Columns.Add("Major", typeof(string));
            dt.Columns.Add("Group", typeof(string));
            dt.Columns.Add("FormOfStudy", typeof(string));
            dt.Columns.Add("BeginningYear", typeof(int));

            foreach (var p in list)
            {
                dt.Rows.Add(new object[] { p.Id, p.Name, p.Faculty, p.Department, p.Major, p.Group, p.FormOfStudy, p.BeginningYear });
            }

            return dt;
        }

        public IEnumerable<Postgrad> ToList(IEnumerable<XElement> list)
        {
            List<Postgrad> postgrads = new List<Postgrad>();
            // Iterate through the results of the query
            foreach (var x in list)
            {
                // Do something with the result
                postgrads.Add(new Postgrad
                {
                    Id = int.Parse(x.Element("Id").Value),
                    Name = x.Element("Name").Value,
                    Faculty = x.Element("Faculty").Value,
                    Department = x.Element("Department").Value,
                    Major = x.Element("Major").Value,
                    Group = x.Element("Group").Value,
                    FormOfStudy = x.Element("FormOfStudy").Value,
                    BeginningYear = int.Parse(x.Element("BeginningYear").Value)
                });
            }

            return postgrads;
        }

        public DataTable ToDataTable(List<IXmlConvertible> list)
        {
            throw new NotImplementedException();
        }
    }
}
