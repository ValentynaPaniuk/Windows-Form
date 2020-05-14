using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{

    [Serializable]
    public class Answer
    {
        public string answer { get; set; }
        public bool check { get; set; }

        public override string ToString()
        {
            return $"{answer}";
        }
    }
    


    
}
