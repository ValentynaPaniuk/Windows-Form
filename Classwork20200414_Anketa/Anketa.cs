using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Classwork20200414_Anketa
{
    public partial class Anketa : Form
    {
        List<Person> people = new List<Person>();
        public Anketa()
        {
            
                    InitializeComponent();
    
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = TextBox1.Text;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue))
                e.Handled = true;
            label1.Text = TextBox1.Text;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            label1.Text = TextBox1.Text;
        }

        int year = 0;
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("!!! Choose the correct event time");
            }

            DateTime dateNow = DateTime.Now;
            year = dateNow.Year - DateTimePicker1.Value.Year;
            if (dateNow.Month < DateTimePicker1.Value.Month ||
                (dateNow.Month == DateTimePicker1.Value.Month && dateNow.Day < DateTimePicker1.Value.Day)) year--;

            label3.Text = $"Age: {year}";
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {

            Person one = new Person();
            one.Name = TextBox1.Text;
                     
            foreach (Control item in this.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton temp = item as RadioButton;
                   
                  if (temp.Checked)
                        one.Gender = temp.Text;
                  
                }

            }

           
            one.Bitrhday = DateTimePicker1.Value;
           
           
            foreach (Control x in panel1.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                       one.Language.Add(temp.Text);
                      
                    }
                }
            }
            //foreach (var item in one.Language)
            //{
            //    MessageBox.Show($"Language: {item}");
            //}


            foreach (Control x in panel2.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                        one.Language_.Add(temp.Text);

                    }
                }
            }
            //foreach (var item in one.Language_)
            //{
            //    MessageBox.Show($"Language: {item}");
            //}

            foreach (Control x in panel3.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked && temp.Text != "Another")
                    {
                        one.Hobby.Add(temp.Text);
                   
                    }
                    if (temp.Checked && temp.Text == "Another")
                    {
                        one.Hobby.Add(textBox2.Text);
                    }
                   

                }
            }

            if (one.Name == "Enter name" || one.Name == null)
            {
                MessageBox.Show("Enter name, please");
                TextBox1.Focus();
                return;
            }

            if (one.Gender == null)
            {
                MessageBox.Show("Select gender, please");
                return;
            }
            textBox2.Visible = false;



            people.Add(one);
            
            ListBox1.Items.Add(one.Name);
            ListBox1.Items.Add(one.Bitrhday);
            ListBox1.Items.Add(one.Gender);
        
            foreach (var item in one.Language)
            {
                ListBox1.Items.Add(item);
            }
            foreach (var item in one.Language_)
            {
                ListBox1.Items.Add(item);
            }

            foreach (var item in one.Hobby)
            {
                ListBox1.Items.Add(item);
            }

            //////////////////////////

            TextBox1.Clear();
            TextBox1.Focus();
            DateTimePicker1.Value = DateTime.Now;
            foreach (Control x in Controls)
            {
                if (x is RadioButton)
                {
                    RadioButton temp = x as RadioButton;

                    if (temp.Checked)
                    {
                        temp.Checked = false;

                    }
                }
            }



            foreach (Control x in panel1.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                        temp.Checked = false;

                    }
                }
            }

            foreach (Control x in panel2.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                        temp.Checked = false;

                    }
                }
            }

            foreach (Control x in panel3.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                        temp.Checked = false;
                        textBox2.Text = String.Empty;
                        textBox2.Visible = false;

                    }

                }
            }


            MessageBox.Show($"Questionnaire saved");

        }


        private void Rb_man_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Text =="Man")
           
                PictureBox1.Image = Image.FromFile("../../img/1.jpg");
          
            else
                PictureBox1.Image = Image.FromFile("../../img/2.jpg");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            string file = DateTime.Now.ToShortDateString() + "_Person" + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            xml.Serialize(stream, people);
            stream.Close();
            MessageBox.Show("File.xls \"Peoples\" saved !");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string file = DateTime.Now.ToShortDateString() + "_Person" + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                people = (List<Person>)xml.Deserialize(stream);
            }
                   
            ListBox1.Items.Clear();
                foreach (var item in people)
                {
                     ListBox1.Items.Add(item.Name);
                     ListBox1.Items.Add(item.Gender);
                     ListBox1.Items.Add(item.Bitrhday);
                foreach (var item1 in item.Language)
                {
                    ListBox1.Items.Add(item1);
                }
                foreach (var item1 in item.Language_)
                {
                    ListBox1.Items.Add(item1);
                }
                foreach (var item1 in item.Hobby)
                {
                    ListBox1.Items.Add(item1);
                }
            }
           
            MessageBox.Show("File has loaded fron file.XML!");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            people.Clear();
            ListBox1.Items.Clear();
            TextBox1.Clear();
            DateTimePicker1.Value = DateTime.Now;


            //switch (Rb_man.Checked)
            //{
            //    case true:
            //        Rb_man.Checked = false;
            //        break;
            //    case false:
            //        Rb_man.Checked = true;
            //        break;
            //}

            //switch (Rb_woman.Checked)
            //{
            //    case true:
            //        Rb_woman.Checked = false;
            //        break;
            //    case false:
            //        Rb_woman.Checked = true;
            //        break;
            //}

            foreach (Control x in Controls)
            {
                if (x is RadioButton)
                {
                    RadioButton temp = x as RadioButton;
                 
                    if (temp.Checked)
                    {
                        temp.Checked = false;

                    }
                }
            }



            foreach (Control x in panel1.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                        temp.Checked = false;

                    }
                }
            }

            foreach (Control x in panel2.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                        temp.Checked = false;

                    }
                }
            }

            foreach (Control x in panel3.Controls)
            {
                if (x is CheckBox)
                {
                    CheckBox temp = x as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                    {
                        temp.Checked = false;

                    }
                }
            }


        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            textBox2.Focus();
                  
           
        }
    }
       
}
