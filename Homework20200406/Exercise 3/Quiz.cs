using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Quiz
    {
        /*Вікторина(Quiz)
	                    список питань (List<Question>)
	                    метод додавання питання( void AddQuestion(Question q))
	                    метод запуску Тестування (void Run())
         */

        private List<Question> list;



        public Quiz()       {   list = new List<Question>();       }

        public void AddQuestion(Question q)
        {
            list.Add(q);
        }

       
        public void Run()
        {
            Console.WriteLine("       ========= TESTING ======== ");
            Console.WriteLine("       Please answer the question: \n\n");
           
            int correct_answer = 0;
            foreach (var e in list)
            {
                bool choiсe;
                Console.WriteLine("       Enter TRUE or FALSE, please...\n");
                Console.WriteLine($"{e.Question_}");
              
                choiсe = bool.Parse(Console.ReadLine());

                if (choiсe == true)
                {
                  Console.WriteLine(e.Answer ? "This is the CORRECT answer1" : "This is not the correct answer");  // output: CORRECT
                    Console.WriteLine($"Answer YES: {e.Answer}");
                  correct_answer++;
                }
                else if (choiсe == false)
                {
                    Console.WriteLine(false ? "This is the correct answer2" : "This is NOT THE CORRECT answer");  // output: NOT CORRECT
                    Console.WriteLine($"Answer NOT: {e.Answer}");
                  
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine($"\n TRUE question: {correct_answer}; All question = {list.Count};");
              
        }


    }
}
