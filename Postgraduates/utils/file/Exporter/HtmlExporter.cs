using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Postgraduates.utils.file.Exporter
{
    internal class HtmlExporter : IExporter
    {
        public void ExportTable(DataTable table, string path)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"ru\">");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta charset=\"UTF-8\">");
            sb.AppendLine("<title>HTML Document</title>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");

            sb.Append("<table>");
            sb.Append("<thead>");
            sb.Append("<tr>");

            foreach (DataColumn column in table.Columns)
            {
                sb.Append("<th>");
                sb.Append(column.ColumnName);
                sb.Append("</th>");
            }
            sb.Append("</tr>");
            sb.Append("</thead>");
            foreach (DataRow row in table.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn column in table.Columns)
                {
                    sb.Append("<td>");
                    sb.Append(row[column.ColumnName].ToString());
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");

            string htmlOutput = sb.ToString();

            File.WriteAllText(path, htmlOutput);
        }
    }
}
