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

namespace Classwork20200429_Registration
{
    public partial class Registrasion : Form
    {
        /*Створити форму для реєстрації у соцмережі з текстовими полями
	Ім"я(тільки букви)
	Прізвище(тільки букви)
	Рік народження(з віку 12 років вважати валідно)
	Телефон
    та кнопкою Зареєеструвати.
    Перевіряти валідність введених даних.
    Використати у програмі ErrorProvider для сигналізації про помилки у введених даних.

*****Скористатися обробкоюб подій Validating, Validated
         */

        bool ValidName = false;
        bool ValidSurname = false;
        bool ValidYear = false;
        List<Person> people = new List<Person>();

        public Registrasion()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Status form";


            Tb_Phone.Text = "Enter Phone number (10-12 digits)";//подсказка
            Tb_Phone.ForeColor = Color.Gray;

         
        }

        //Вводити лише букви
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (Char)Keys.Back == e.KeyChar) return;
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidName && ValidSurname && ValidYear)
            {
                toolStripStatusLabel1.Text = "Registration was successful";

            }
            else
                errorProvider1.SetError((sender as Button), "Check that all fields are filled");


            Person one = new Person();
            one.Name = Tb_Name.Text;
            one.Surname = Tb_Surname.Text;
            one.Age = DateTime.Now.Year - Convert.ToInt32(Tb_Year.Text);

            one.Phone = Convert.ToInt32(Tb_Phone.Text);
            one.Question = Cb_guestion.Text;
            one.Answer = Tb_Answer.Text;
            people.Add(one);

            listBox1.Items.Add(one);

            //Tb_Name.Clear();
            //Tb_Surname.Clear();
            //Tb_Year.Clear();

            TextBox cb = sender as TextBox;
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    Cleare(item);
                }
            }


        }

        private void Cleare(Object tb)
        {
            (tb as TextBox).Text = String.Empty;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (Tb_Name.Text == String.Empty)
                label1.Visible = true;

            else
            {
                label1.Visible = false;
                ValidName = true;

            }
            if (Tb_Surname.Text == String.Empty)
                label2.Visible = true;
            else
            {
                label2.Visible = false;
                ValidSurname = true;

            }
            if (Tb_Year.Text == String.Empty)

                label3.Visible = true;
            else
            {
                label3.Visible = false;
                Lb_Year.Text = $"Age: {DateTime.Now.Year - Convert.ToInt32(Tb_Year.Text)}";
                ValidYear = true;
                errorProvider1.Clear();

            }


        }

        //Додаємо фото
        private void Tb_Image_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            pictureBox1.Load(filename);
            Tb_Image.Visible = false;
            Lb_Image.Visible = false;
            Cb_guestion.Focus();

        }
        //Вводити лише числа
        private void Tb_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (Char)Keys.Back == e.KeyChar) return;
            e.Handled = true;
        }

        //Перевіряємо поле вік на відповідність
        private void Tb_Year_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Now.Year - Convert.ToInt32(Tb_Year.Text) <= 12 || Convert.ToInt32(Tb_Year.Text) <= 1920)
                errorProvider1.SetError(Tb_Year, "Check that you have entered the year correctly");

        }

        private void Tb_Phone_Click(object sender, EventArgs e)
        {
            Tb_Phone.Text = null;
            Tb_Phone.ForeColor = Color.Black;
        }

        
    }

}