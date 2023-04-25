using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Postgrad));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Postgrad)serializer.Deserialize(reader);
// }

namespace Postgraduates.model
{
    internal class Postgrad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Major { get; set; }
        public string Group { get; set; }
        public string FormOfStudy { get; set; }
        public int BeginningYear { get; set; }

        public Postgrad() { }

        public Postgrad(int id, string name, string faculty, string department, string major, string group, string formOfStudy, int beginningYear) 
        {
            Id = id; 
            Name = name;
            Faculty = faculty;
            Department = department;
            Major = major;
            Group = group;
            FormOfStudy = formOfStudy;
            BeginningYear = beginningYear;
        
        }
    }
}
