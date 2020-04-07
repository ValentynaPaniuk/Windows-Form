using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Створити програму Вікторина(Тестування). 
              Програма задає декілька питань користувачу, очікуючи відповіді типу Так-Ні.
              Програма видає результат проходження вікторини(тесту): 
              кількість правильних та загальне число відповідей(н-д, "правильних відповідей 2, всього питань  5")   
              *Бажано створення класів:
                    Питання(Question)
	                    текст питання(string)
	                    відповідь(bool)
                    Вікторина(Quiz)
	                    список питань (List<Question>)
	                    метод додавання питання( void AddQuestion(Question q))
	                    метод запуску Тестування (void Run())

            Метод Run() запускає тестування, виводить кожне питання зі списку питань, аналізує відповіді 
            на правильність та формує результат(кількість правильних)*/


            Question one       = new Question("   Quarantine will end on April 24? ");
            Question two       = new Question("   My daughter was born on September 24 ? ");
            Question  three    = new Question("   I was born on August 15 ? ");

           
            Quiz quiz = new Quiz();

            quiz.AddQuestion(one);
            quiz.AddQuestion(two);
            quiz.AddQuestion(three);

            quiz.Run();

            Console.WriteLine("\n\n====================================");
            Console.WriteLine("    Enter NEW question: ");
            Question four = new Question(Console.ReadLine());
            quiz.AddQuestion(four);
            
            quiz.Run();
            

          
        }
    }
}
 