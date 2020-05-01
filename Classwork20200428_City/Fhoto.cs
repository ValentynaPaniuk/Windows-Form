using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200428_City
{

    public partial class Fhoto : Form
    {
        /*Створити застосування, яке дозволяє обрати місто із списку міст(ComboBox)
При виборі певного міста у PictureBox виводити зображення міста(фото).
	Розмістити на формі TrackBar або HScrollBar(VScrollBar) для перегляду інших фото міста.

Інформацію про зроблений вибір показувати на рядку стану( Місто, Кількість переглядів).

Додати елемент  LinkedLabel або Label(IsLink = true)на рядку стану. При виборі певного міста з'являється на  LinkedLabel(Label) назва відповідного
інтернет-ресурсу. При кліку на LinkedLabel, переходити на відповідний ресурс.

!!! Для розвязку задачі визначити  клас для збереження інформації про місто(City)
	назва,
	адреса інтернет -ресурсу,
	список рядків(шляхів до файлів з фото міста)
Створити у програмі список міст(Рівне, Київ та ін.).
Заповнити список даними "вручну" або  отримати з створеного раніше текстового файлу.
 */

        List<City> names = new List<City>();
       
        public Fhoto()
        {
            InitializeComponent();

            HScrollBar1.LargeChange = HScrollBar1.SmallChange = 1; //Однаковий великий і малий крок

            City Kyiv = new City() { Name = "Kyiv", Address = "https://uk.wikipedia.org/wiki/%D0%9A%D0%B8%D1%97%D0%B2" };
            Kyiv.Path.Add("../../img/Kyiv.jpg");
            Kyiv.Path.Add("../../img/Kyiv1.jpg");
            Kyiv.Path.Add("../../img/Kyiv2.jpg");

            City Lviv = new City() { Name = "Lviv", Address = "https://uk.wikipedia.org/wiki/%D0%9B%D1%8C%D0%B2%D1%96%D0%B2" };
            Lviv.Path.Add("../../img/Lviv.jpg");
            Lviv.Path.Add("../../img/Lviv1.jpg");
            Lviv.Path.Add("../../img/Lviv2.jpg");

            City Odessa = new City() { Name = "Odessa", Address = "https://uk.wikipedia.org/wiki/%D0%9E%D0%B4%D0%B5%D1%81%D0%B0" };
            Odessa.Path.Add("../../img/Odessa.jpg");
            Odessa.Path.Add("../../img/Odessa1.jpg");
            Odessa.Path.Add("../../img/Odessa2.jpg");

            City Rivne = new City() { Name = "Rivne", Address = "https://uk.wikipedia.org/wiki/%D0%A0%D1%96%D0%B2%D0%BD%D0%B5" };
            Rivne.Path.Add("../../img/Rivne.jpg");
            Rivne.Path.Add("../../img/Rivne1.jpg");
            Rivne.Path.Add("../../img/Rivne2.jpg");

            names.Add(Kyiv);
            names.Add(Lviv);
            names.Add(Odessa);
            names.Add(Rivne);
          

            ComboBox1.Items.Add(Kyiv.Name);
            ComboBox1.Items.Add(Lviv.Name);
            ComboBox1.Items.Add(Odessa.Name);
            ComboBox1.Items.Add(Rivne.Name);

            ToolStripProgressBar1.Value = 0;

            if (ComboBox1.SelectedIndex == 0)
                linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = $"{ names[0].Address.ToString()}" });
            if (ComboBox1.SelectedIndex == 1)
                linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = $"{ names[1].Address.ToString()}" });
            if (ComboBox1.SelectedIndex == 2)
                linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = $"{ names[2].Address.ToString()}" });
            if (ComboBox1.SelectedIndex == 3)
                linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = $"{ names[3].Address.ToString()}" });



        }

        int counter_0 = 0;
        int counter_1 = 0;
        int counter_2 = 0;
        int counter_3 = 0;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;
          
            if (ComboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < names[0].Path.Count; i++)
                {
                    HScrollBar1.Maximum = names[0].Path.Count - 1;//Задаємо максимум для полоси прокрутки
                    pictureBox1.Load($"{names[0].Path[i].ToString()}");
                }
                counter_0++;
                linkLabel1.Text = names[0].Name.ToString();
                toolStripStatusLabel1.Text = $"{names[0].Name} {counter_0}";
                ToolStripProgressBar1.Maximum = names[0].Path.Count;
               
            } 
                 
            if (ComboBox1.SelectedIndex == 1)
            {
               for (int i = 0; i < names[1].Path.Count; i++)
                {
                   HScrollBar1.Maximum = names[1].Path.Count - 1;
                   pictureBox1.Load($"{names[1].Path[i].ToString()}");
                }
                counter_1++;
                linkLabel1.Text = names[1].Name.ToString();
                toolStripStatusLabel1.Text = $"{names[1].Name} {counter_1}";
                ToolStripProgressBar1.Maximum = names[1].Path.Count;

            }

            if (ComboBox1.SelectedIndex == 2)
            {
               
                for (int i = 0; i < names[2].Path.Count; i++)
                {
                    HScrollBar1.Maximum = names[2].Path.Count - 1;
                    pictureBox1.Load($"{names[2].Path[i].ToString()}");

                }
                counter_2++;          
                linkLabel1.Text = names[2].Name.ToString();
                toolStripStatusLabel1.Text = $"{names[2].Name} {counter_2}";
                ToolStripProgressBar1.Maximum = names[2].Path.Count;

            }

            if (ComboBox1.SelectedIndex == 3)
            {
              
                for (int i = 0; i < names[3].Path.Count; i++)
                {
                   HScrollBar1.Maximum = names[3].Path.Count - 1;
                   pictureBox1.Load($"{names[3].Path[i].ToString()}");
                }
                counter_3++;
                linkLabel1.Text = names[3].Name.ToString();
                toolStripStatusLabel1.Text = $"{names[3].Name} {counter_3}";
                ToolStripProgressBar1.Maximum = names[3].Path.Count;

            }
               
          

        }

        private void HScrollBar1_ValueChanged(object sender, EventArgs e)
        {

            int j = HScrollBar1.Value;
            if (ComboBox1.SelectedIndex == 0)
            {
                pictureBox1.Load($"{names[0].Path[j].ToString()}");
                ToolStripProgressBar1.Value = j+1;
            }

            if (ComboBox1.SelectedIndex == 1)
            {
                pictureBox1.Load($"{names[1].Path[j].ToString()}");
                ToolStripProgressBar1.Value = j + 1;
            }

            if (ComboBox1.SelectedIndex == 2)
            {
                pictureBox1.Load($"{names[2].Path[j].ToString()}");
                ToolStripProgressBar1.Value = j + 1;
            }

            if (ComboBox1.SelectedIndex == 3)
            {
                pictureBox1.Load($"{names[3].Path[j].ToString()}");
                ToolStripProgressBar1.Value = j + 1;
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].LinkData
            //Process.Start(e.Link.LinkData.ToString());

        }

             
    }
}
