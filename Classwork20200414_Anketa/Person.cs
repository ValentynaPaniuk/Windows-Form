using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200414_Anketa
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Bitrhday { get; set; }
        public List<string> Language = new List<string>();
        public List<string> Language_ = new List<string>();
        public List<string> Hobby = new List<string>();
        

        public Person() { }
      

    }
}
