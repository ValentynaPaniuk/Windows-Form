using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework20200406
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написати програму, яка веде підрахунок кліків лівою, правою, середньою кнопками по формі. 
            Статистику виводити в заголовок форми. 
            На формі зробити кнопку "Очищення статистики", яка після кліку онуляє рахунок кліків.
             */
            Form form = new Form();
            form.Text = "Сlicks";
            form.Size = new Size(500, 500);


            Button btn_clear = new Button();
            btn_clear.Size = new Size(100, 50);
            btn_clear.Text = "Clear";
            btn_clear.BackColor = Color.Red;
            btn_clear.Top = 100;
            btn_clear.Left = 150;


            form.Controls.Add(btn_clear);

            btn_clear.MouseClick += Btn_clear_MouseClick;
            form.MouseDown += Form_MouseDown;
           
            form.ShowDialog();

        }

        private static void Btn_clear_MouseClick(object sender, MouseEventArgs e)
        {
            left = 0;
            right = 0;
            middle = 0;
            ((sender as Button).Parent as Form).Text = $"Left: {left.ToString()}; Right: {right.ToString()}; Middle: {middle.ToString()}";

        }

        static int left = 0, right = 0, middle = 0;
        private static void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
           switch (e.Button)
            {
                case MouseButtons.Left:
                    left++;
                    break;
                case MouseButtons.Right:
                    right++;
                    break;
                case MouseButtons.Middle:
                    middle++;
                    break;
             
            }
             (sender as Form).Text = $"Left: {left.ToString()}; Right: {right.ToString()}; Middle: {middle.ToString()} ";
        }
    }
}
