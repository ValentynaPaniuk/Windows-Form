using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200504_Telephone_Directory
{
    public class Contact
    {
        public string Name { get;set;}
        public int Phone { get;set;}
        public string Path { get; set; }

        public Contact()
        {
            Name = "unknown";
            Phone = 0;
            Path = "unknown";
        }
        public Contact(string name, int phone, string path)
        {
            Name = name; Phone = phone;
        }
        public override string ToString()
        {
            return Name + "  -> " + Phone;
        }

    }
}
