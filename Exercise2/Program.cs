using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написати програму, яка з кожним кліком по формі буде змінювати фон форми на кольори веселки (і так циклічно)
             */

            Form form = new Form();
            form.Text = "Сlicks";
            form.Size = new Size(500, 500);
            form.MouseClick += Form_MouseClick;

            form.ShowDialog();

        }
        static int index = 0;
        static Color[] colors = { Color.Red, Color.Orange, Color.Green, Color.Blue, Color.DarkBlue, Color.Violet };
        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as Form).BackColor = colors[index++];
            if (index == colors.Length)
                index = 0;
        }
    }
}
