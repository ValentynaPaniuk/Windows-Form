using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200414_Anketa
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
            Application.Run(new Anketa());
        }
        /*Створити додаток "Анкета".
    /////////////////// На формі розмістити текстове поле для вводу імені(перевіряти валідність імені)
	/////////////////// Стать(RadioButtons)
	/////////////////// Вік(label) або дата народження(DateTimePicker, MonthCalendar, TextBox, MaskedTextBox)
	/////////////////// Знання мов програмування С++, C# чи ін.(прапорці, CheckBox-и)
	/////////////////// Знання іноземної мови (тристановий! прапорець, CheckBox з властивістю ThreeStae = true)	
	/////////////////// Звіт(сформована анкета, Label або TextBox або ListBox)
	/////////////////// Кнопку для формування анкети(виведення  на форму)  BtnSave
	/////////////////// PictureBox - в залежності від обраної статі - встановити відповідне зображення (PictureBox.Image = Image.FromFile(....))

****  Save to file  ??  --->  Serialization
****  Load from file  ??  --> Serialization
         */
    }
}
