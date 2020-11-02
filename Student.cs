using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateofbirth { get; set; }

        internal Student(int id, string name, DateTime dateofbirth)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;
        }

    }
    class course
    {
        public int id { get; set; }
        public string name { get; set; }
        public int DurationInDays { get; set; }
        public int fees { get; set; }
    }
}
