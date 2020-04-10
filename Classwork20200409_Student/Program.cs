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

      /*  Анкета:

        Поля для вводу Імені, Прізвище, Хоббі, Комбобокс - для статі, DateTimePicker - Дата народження
                 Label - на лейбу розраховується автоматично вік студента
        Кнопка - Зберегти - серіалізує об'єкт Студента в файл
        Кнопка - Завантажити - десеріалізує збереженого студента із файла(Бажано останнього)
        Кнопка - Очистити - очищає всі текстові поля
        Після десеріалізації "розкидати" по елементам керування відповідні дані(Дата народження, на текстбокси ім'я, прізвище, хобі )...

        ЗАУВАЖЕННЯ***
        Обов'язково використати клас Student*/
    }
}
