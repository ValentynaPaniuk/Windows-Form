using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200409_Student
{
    [Serializable]
   
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Hobby { get; set; }

        public DateTime Birthday { get; set; }

        public Student() { }

        public override string ToString()
        {
            return $"{this.Birthday}  {this.Name} {this.Surname} {Gender} {this.Hobby}";
        }

       

    }
}
