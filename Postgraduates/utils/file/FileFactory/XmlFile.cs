using Postgraduates.model;
using Postgraduates.utils.Converter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Postgraduates.utils.file.FileFactory
{
    class XmlFile : PostgradFile
    {
        public XmlFile() : base() { }

        public XmlFile(string text) : base(text) {}

        private XmlDocument _document = new XmlDocument();
        private PostgraduatesType _type = PostgraduatesType.Unknown;

        override public void Save(string path)
        {
            File.WriteAllText(path, Text);
        }

        public override string Read(string path)
        {
            _document = new XmlDocument();
            _document.Load(path);
            return ToString();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (XmlNode node in _document.DocumentElement.ChildNodes)
            {
                builder.AppendLine(node.InnerText); 
            }

            return builder.ToString();
        }

        public PostgraduatesType GetType()
        {
            return _type;
        }

        public List<Postgrad>? TryParsePostgrads(string path)
        {
            XDocument xmlDoc = XDocument.Load(path);
            if (xmlDoc.Root == null || xmlDoc.Root.Name != XmlRootConstants.Postgrads)
            {
                return null;
            }
            _type = PostgraduatesType.Postgrad;
            var list = xmlDoc.Root.Elements()
                                       .Select(x => new Postgrad
                                       {
                                           Id = int.Parse(x.Element("Id").Value),
                                           Name = x.Element("Name").Value,
                                           Faculty = x.Element("Faculty").Value,
                                           Department = x.Element("Department").Value,
                                           Major = x.Element("Major").Value,
                                           Group = x.Element("Group").Value,
                                           FormOfStudy = x.Element("FormOfStudy").Value,
                                           BeginningYear = int.Parse(x.Element("BeginningYear").Value)
                                       })
                                       .ToList();
            return list;
        }

        public List<Exam>? TryParseExams()
        {
            XmlElement? xRoot = _document.DocumentElement;
            if (xRoot == null || xRoot.Name != XmlRootConstants.Exams)
            {
                return null;
            }
            Debugger.Log(1, "xmldocument", xRoot.Name);
            _type = PostgraduatesType.Exam;
            return null;
        }
    }
}

//XmlElement? xRoot = _document.DocumentElement;
//if (xRoot == null || xRoot.Name != XmlRootConstants.Postgrads)
//{
//    return null;
//}
//Debugger.Log(1, "xmldocument", xRoot.Name);
//XmlSerializer serializer = new XmlSerializer(typeof(List<Postgrad>));
//using (FileStream stream = File.OpenRead(path))
//{
//    List<Postgrad> dezerializedList = 
//        (List<Postgrad>)serializer.Deserialize(stream);
//}