using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200408_Event_Planning
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
            Application.Run(new Form_planning());
        }

        /*Створити програму "Планування подій(справ)"(Version 1.0).
  На головній формі розмістити 
 - текстове поле для введення назви події(справи), обов'язкове поле
 - текстове поле для місця події(не обов'язкове)
 - DateTimePicker або MonthCalendar для вибору дати події(по замовчуванню на завтра)
 - текстове поле для вибору пріоритут події(встановити властивість для можливості автозаповнення :високий, середній, низький), по замовчуванню - середній
 - кнопку Додати, що додає відповідну подію у  статичний текст( чи ListBox: listbox1.Items.Add() - доповнення списку listbox1)
 - кнопку очищення списку подій
 - кнопку збереження плану подій у текстовому(xml чи json) файлі (з назвою, що містить поточну дату).
Зауваження. Не дозволяти планування на "вчора"

При розв"язуванні задачі визначити клас Подія(Event) з полями назва, дата-час, пріоритет, місце події.
Визначити також клас для серіалізації( десеріалізації) списку подій.
      */
    }
}
