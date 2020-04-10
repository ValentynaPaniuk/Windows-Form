using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200409_Student
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }


        /*  Ім'я 
            Прізвище
            Дата народження  ----- лейба - вік
            Вибрати стать  (Combobox)
            Хоббі - текстове поле
            
            кнопки: зберегти (xml), завантажити останню анкету - десеріалізація
            
            class Student  {}
         */
    }
}
