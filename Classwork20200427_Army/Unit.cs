using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200427_Army
{
    [Serializable]
    public class Unit
    {
        public string Name { get; set; }

        public Unit() { }
        public string Tostring()
        {
            return $"{Name}";
        }
    }
}
