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
        List<Bitmap> PictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Pazzle()
        {
            InitializeComponent();

            //Дозволити перетягувати об'єкти в form
            this.AllowDrop = true;
            //Дозволити перетягувати об'єкти в tableLayoutPanel1
            tableLayoutPanel1.AllowDrop = true;
            // //Дозволити перетягувати об'єкти в усі PictureBox
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is PictureBox)
                {
                    item.AllowDrop = true;
                }
            }
            //Заповнюємо картинками PictureBox
            Pb_00.Image = Image.FromFile(@"..\..\img\00.jpg");
            Pb_01.Image = Image.FromFile(@"..\..\img\01.jpg");
            Pb_02.Image = Image.FromFile(@"..\..\img\02.jpg");
            Pb_10.Image = Image.FromFile(@"..\..\img\10.jpg");
            Pb_11.Image = Image.FromFile(@"..\..\img\11.jpg");
            Pb_12.Image = Image.FromFile(@"..\..\img\12.jpg");
            Pb_20.Image = Image.FromFile(@"..\..\img\20.jpg");
            Pb_21.Image = Image.FromFile(@"..\..\img\21.jpg");
            Pb_22.Image = Image.FromFile(@"..\..\img\22.jpg");
            pictureBox2.Image = Image.FromFile(@"..\..\img\Picture_All.jpg");

            toolStripStatusLabel1.Text = "";

        }

        //DragEnter - розпочинаємо переміщення
        private void Pb_00_DragEnter(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            e.Effect = DragDropEffects.Copy;
            this.Text = "DragEnter";
            pictureBox1.Image = pb.Image;

            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //    e.Effect = DragDropEffects.Copy;

        }

        //DragLeave - виходимо за область об'єкта керування з якого переміщуємо
        //DragOver - переміщуємо над якимось елементом
        //DragDrop - коли відпускаємо об'єкт, що переносили
        private void Pb_00_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            this.Text = "DragDrop";

            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    PictureBox pb = sender as PictureBox;
            //    object data = e.Data.GetData(DataFormats.FileDrop); // коли виділено декілька об'єктів для переміщення 
            //    string fileName = ((string[])data)[0]; //Шлях до першого елемента
            //    pb.Image = Image.FromFile(fileName);
            //}

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
            Pb_00.Image = Image.FromFile(@"..\..\img\00.jpg");
            Pb_01.Image = Image.FromFile(@"..\..\img\01.jpg");
            Pb_02.Image = Image.FromFile(@"..\..\img\02.jpg");
            Pb_10.Image = Image.FromFile(@"..\..\img\10.jpg");
            Pb_11.Image = Image.FromFile(@"..\..\img\11.jpg");
            Pb_12.Image = Image.FromFile(@"..\..\img\12.jpg");
            Pb_20.Image = Image.FromFile(@"..\..\img\20.jpg");
            Pb_21.Image = Image.FromFile(@"..\..\img\21.jpg");
            Pb_22.Image = Image.FromFile(@"..\..\img\22.jpg");

            counter = 0;
            toolStripStatusLabel1.Text = $"Moves made: {counter}";

        }
    }
}
