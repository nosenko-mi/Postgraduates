using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.model
{
    internal static class PostgradExtentions
    {
        public static DataTable ToDataTable(this IEnumerable<Postgrad> list)
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
                dt.Rows.Add(p.ToDataRow);
            }

            return dt;
        }
    }
}
