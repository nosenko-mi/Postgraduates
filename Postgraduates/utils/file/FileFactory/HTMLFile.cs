﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Postgraduates.utils.file.FileFactory
{
    internal class HTMLFile : PostgradFile
    {
        public HTMLFile() : base() { }

        public HTMLFile(string text) : base(text) { }

        public override string Read(string path)
        {
            HtmlAgilityPack.HtmlDocument file = new HtmlAgilityPack.HtmlDocument();
            file.Load(path);
            // Select all <p> tags
            HtmlNodeCollection pTags = file.DocumentNode.SelectNodes("//p");

            StringBuilder sb = new StringBuilder();
            // Loop through all <p> tags and do something with them
            foreach (HtmlNode pTag in pTags)
            {
                sb.Append(pTag.InnerText).Append("\n");
            }
            Text = sb.ToString();
            return Text;
        }

        override public void Save(string path)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"ru\">");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta charset=\"UTF-8\">");
            sb.AppendLine("<title>HTML Document</title>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");

            var paragraphs = Text.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            foreach (string p in paragraphs)
            {
                sb.AppendLine($"<p>{p}</p>");
            }

            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            string htmlOutput = sb.ToString();

            File.WriteAllText(path, htmlOutput);
        }
    }
}


