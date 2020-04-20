using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200415_Event_Planning
{
    class Event
    {
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string Priority { get; set; }
       

        public override string ToString()
        {
            return $"{DateTime}  {Priority} {Name}";
        }
        public Event()
        {
        }
    }
}
