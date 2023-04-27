using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgraduates.model
{
    internal class Exam
    {
        public string Group { get; set; }
        public string Discipline { get; set; }
        public string Auditory { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Type { get; set; }

        public Exam(string group, string discipline, string auditory, DateTime date, DateTime time, string type)
        {
            Group = group;
            Discipline = discipline;
            Auditory = auditory;
            Date = date;
            Time = time;
            Type = type;
                
        }
    }
}
