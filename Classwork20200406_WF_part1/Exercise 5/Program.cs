using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    class Program
    {
        static int counter = 0;
        static Color[] colors = { Color.Red, Color.Orange, Color.Green, Color.Blue, Color.DarkBlue, Color.Violet };
        static int index = 0;
        static void Main(string[] args)
        {
            /*
             * Написати програму, яка веде підрахунок кліків по формі. 
              Статистику виводити в заголовок форми. 
              На формі зробити кнопку "Очищення статистики", яка після кліку онуляє рахунок кліків.

             Написати програму, яка з кожним кліком по формі буде змінювати фон форми на кольори веселки
             */
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.StartPosition = FormStartPosition.CenterScreen;


            Button button_click = new Button();
            button_click.Text = "Press";
            button_click.Size = new Size(100, 20);
            button_click.BackColor = Color.Chocolate;
            button_click.Top = 100;
            button_click.Left = 100;
            form.Controls.Add(button_click);

            Button button_clear = new Button();
            button_clear.Text = "Clear statistics";
            button_clear.Size = new Size(100, 20);
            button_clear.BackColor = Color.Yellow;
            button_clear.Top = 100;
            button_clear.Left = 250;
            form.Controls.Add(button_clear);


            button_click.MouseClick += Button_click_MouseClick;
            button_clear.MouseClick += Button_clear_MouseClick;

            form.Click += Form_Click;
   
            form.ShowDialog();

        }

        private static void Form_Click(object sender, EventArgs e)
        {
            (sender as Form).BackColor = colors[index++];
            if (index == colors.Length) index = 0;
        }

        //Метод обнулення лічильника натискання кнопки
        private static void Button_clear_MouseClick(object sender, MouseEventArgs e)
        {
            counter = 0;
            ((sender as Button).Parent as Form).Text = counter.ToString();
            MessageBox.Show($"The counter is reset");


        }

        //Метод підрахунку кількості натискання кнопки
        private static void Button_click_MouseClick(object sender, MouseEventArgs e)
        {
            counter++;
            ((sender as Button).Parent as Form).Text = counter.ToString();
           
        }
    }

}
