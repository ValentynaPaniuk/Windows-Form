using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200507_Pazly
{
    public partial class Pazzle : Form
    {
        int counter = 0;
       
       
        public Pazzle()
        {
            InitializeComponent();

            //Дозволити перетягувати об'єкти в form
            this.AllowDrop = true;
            //Дозволити перетягувати об'єкти в tableLayoutPanel1
            tableLayoutPanel1.AllowDrop = true;
            //Дозволити перетягувати об'єкти в усі PictureBox
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is PictureBox)
                {
                    item.AllowDrop = true;
                }
            }
          
            toolStripStatusLabel1.Text = "Click the Open button: ";

        }

        //DragEnter - розпочинаємо переміщення
        private void Pb_00_DragEnter(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            e.Effect = DragDropEffects.Copy;
            this.Text = "DragEnter";
            pictureBox1.Image = pb.Image;

        }

        //DragLeave - виходимо за область об'єкта керування з якого переміщуємо
        //DragOver - переміщуємо над якимось елементом
        //DragDrop - коли відпускаємо об'єкт, що переносили
        private void Pb_00_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            this.Text = "DragDrop";

        }

        

        //Затискання лівої кнопки миші
        private void Pb_00_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
            this.Text = "Mouse Down";
            pb.Image = pictureBox1.Image;

            counter++;
            toolStripStatusLabel1.Text = $"Moves made: {counter}";
           

        }

        private void cleareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counter = 0;

            Pb_00.Image = Image.FromFile(@"..\..\img\0.jpg");
            Pb_01.Image = Image.FromFile(@"..\..\img\1.jpg");
            Pb_02.Image = Image.FromFile(@"..\..\img\2.jpg");
            Pb_10.Image = Image.FromFile(@"..\..\img\3.jpg");
            Pb_11.Image = Image.FromFile(@"..\..\img\4.jpg");
            Pb_12.Image = Image.FromFile(@"..\..\img\5.jpg");
            Pb_20.Image = Image.FromFile(@"..\..\img\6.jpg");
            Pb_21.Image = Image.FromFile(@"..\..\img\7.jpg");
            Pb_22.Image = Image.FromFile(@"..\..\img\8.jpg");

            //counter = 0;
            toolStripStatusLabel1.Text = $"Moves made: {counter}";
            label1.Visible = false;
           

        }

        string name;
        int[] arr = new int[9];
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            label1.Visible = false;
            int[] arr = new int[9];
            for (int i = 0; i < 8; i++)
            {
                int a = new Random().Next(1, 9);
                if (!arr.Contains(a))
                    arr[i] = a;
                else
                    i--;
            }
            int f = 0;
           
            foreach (PictureBox item in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                if (f < 9)
                {
                    name = arr[f].ToString();
                    item.Image = Image.FromFile($"../../img/{name}.jpg");
                    item.Image.Tag = name;
                    f++;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

            this.Width = 716;
            int i = 0;
            string name;
            bool complite = false;
            foreach (PictureBox item in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                if (i < 8)
                {
                    name = i.ToString();
                    if (name != item.Image.Tag.ToString())
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Attention, please";
                        return;
                    }

                    else
                    {
                        complite = true;
                    }
                    i++;
                }

            }
            if (i == 8 && complite == true)
                label1.Visible = true;
                label1.ForeColor = Color.Green;
                label1.Text = "You are a winner";
           
        }
    }
}
