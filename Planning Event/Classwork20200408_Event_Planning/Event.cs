using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200408_Event_Planning
{
    [Serializable]
    public class Event
    {
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public string Priority { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"{DateTime}  {Priority} {Title} {Place}";
        }
        public Event()
        {
        }
    }
}
