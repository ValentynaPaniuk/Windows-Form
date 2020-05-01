using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200429_Registration
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public Person() { }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname} {this.Age} {Phone} {this.Question} {this.Answer}";
        }

    }
}
