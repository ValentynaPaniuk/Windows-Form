using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    
        [Serializable]
        public class Questions
        {
            public string Question { get; set; }
            public List<Answer> answers = new List<Answer>();
            public bool check { get; set; } = false;

            public Questions() {}
        }
    
}
