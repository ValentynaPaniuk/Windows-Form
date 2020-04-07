using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;


namespace Classwork20200406_WF_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написати програму, яка міститиме дві кнопки: Increase Opacity, Decrease Opacity
              Перша при клікові буде збільшувати прозорість форми, друга - зменшувати*/

            Form form = new Form();
            form.Text = "First form";
            form.BackColor = Color.Chocolate;
            form.Size = new Size(500, 500);
            form.Opacity = 0.5;
            form.StartPosition = FormStartPosition.CenterScreen;

            Button button_One = new Button();
            button_One.Text = "Increase Opacity";
            button_One.BackColor = Color.Yellow;
            button_One.Top = form.Height / 2 - button_One.Height;
            button_One.Left = form.Width / 2 - button_One.Width / 2;


            Button button_Two = new Button();
            button_Two.Text = "Decrease Opacity";
            button_Two.BackColor = Color.Yellow;
            button_Two.Top = form.Height / 4 - button_One.Height;
            button_Two.Left = form.Width / 4 - button_One.Width / 2;
            


            form.Controls.Add(button_One);
            form.Controls.Add(button_Two);
            button_One.Click += Button_One_Click;
            button_Two.Click += Button_Two_Click;
            form.ShowDialog();
  
        }

        private static void Button_Two_Click(object sender, EventArgs e)
        {
               ((sender as Button).Parent as Form).Opacity -= 0.3;
        }

        private static void Button_One_Click(object sender, EventArgs e)
        {
             ((sender as Button).Parent as Form).Opacity += 0.3;
        }
    }
}
