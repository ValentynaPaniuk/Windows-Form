using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200504_Telephone_Directory
{
    public partial class Child : Form
    {
        Contact contact; bool addnew;
      
        public Child(Contact contact, bool addnew)
        {
            InitializeComponent();
            this.addnew = addnew;
            this.contact = contact;//Запомнили ссылку на контакт
            
            if (addnew == false)
            // { если форма открывается для редактирования то сначала занесем информацию о изменяемом контакте в текстовые поля
            {
                Tb_Name.Text = contact.Name;
                Tb_Phone.Text = Convert.ToString(contact.Phone);
                openFileDialog1.FileName = contact.Path;
                this.Text = "Edit contact";//меняем заголовок
            }
            else this.Text = "Add contact";//меняем заголовок если создание товара

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (Tb_Name.Text == "" || Tb_Phone.Text == "")
            {//Проверка заполнения полей
                MessageBox.Show("Fill in all the fields"); return;
            }

            if (contact == null)
                contact = new Contact();
                contact.Name = Tb_Name.Text;
            try
            {/* При преобразовании из строки в вещественное число  произойдет ошибка, если строка неверного формата*/
                contact.Phone = Convert.ToInt32(Tb_Phone.Text);
            }
            catch
            {
                MessageBox.Show("The phone number is incorrect");
                return;
            }
            contact.Path = openFileDialog1.FileName;

            this.DialogResult = DialogResult.OK;
            

        }

        private void Btn_Photo_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\Шаг\WF\Classwork20200504_Telephone_Directory\img";//Початкова папка
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            contact.Path = openFileDialog1.FileName;

        }
    }
    
}
