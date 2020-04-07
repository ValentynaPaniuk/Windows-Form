using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          Написати програму "Впіймай кнопку". 
          Кнопка при наведенні на неї курсора мишки буде міняти свою позицію на рандомну.
          Якщо користувач "спіймає" кнопку, програма має відобразити вікно привітання (MessageBox)*/

            Form form = new Form();
            form.Text = "Second form";
            form.BackColor = Color.Blue;
            form.Size = new Size(500, 500);
            form.Opacity = 1;
            form.StartPosition = FormStartPosition.CenterScreen;

            Button button_One = new Button();
            button_One.Text = "Click";
            button_One.Top = form.Height / 2 - button_One.Height;
            button_One.Left = form.Width / 2 - button_One.Width / 2;
            form.Controls.Add(button_One);
            button_One.MouseHover += Button_One_MouseHover;
            button_One.MouseClick += Button_One_MouseClick;

            form.ShowDialog();

        }

        //Натискання кнопки
        private static void Button_One_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You caught the button!!!");
        }

        //Постійна зміна координат кнопки
        private static void Button_One_MouseHover(object sender, EventArgs e)
        {
             Random rand = new Random();
            (sender as Button).Top = rand.Next(((sender as Button).Parent as Form).ClientSize.Width / 2 - (sender as Button).Width);
            (sender as Button).Left = rand.Next(((sender as Button).Parent as Form).ClientSize.Height / 2 - (sender as Button).Width);

        }


      
    }
}

