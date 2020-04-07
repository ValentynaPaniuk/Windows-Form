using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Question
    {
        /* Питання(Question)
              текст питання(string)
              відповідь(bool)*/

        public string Question_ { get; set; }
        public bool Answer     { get; set; }

        public Question(string questian)
        {
            this.Question_ = questian;
            this.Answer = true;
        }


    }
}
