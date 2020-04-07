using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Програма (консольна) запитує користувача дані про форму:
                   --- Введіть ширину
                   --- Введіть висоту
                   --- Введіть заголовок
                   --- Введіть колір фону
           На основі відповідей користувача має створитись форма, що відповідає введеним параметрам*/

            Form form = new Form();
            Console.WriteLine("Enter NAme of Form:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Width of Form:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height of Form:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Color of Form:");
            form.BackColor = Color.FromName(Console.ReadLine());
          
            form.Width = width;
            form.Height= height;
            form.Text = name;
            form.ShowDialog();


        }
    }
}
