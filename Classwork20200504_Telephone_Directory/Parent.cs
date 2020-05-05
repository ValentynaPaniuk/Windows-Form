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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        //Cleare listbox
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Lb_AllContacts.Items.Clear();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

        }
        //Delete contact
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //Удаление выделенного элемента
            if (Lb_AllContacts.SelectedIndex == -1)//Если товар не выбран
            {
                MessageBox.Show("You have not selected a contact"); return;
            }
            Lb_AllContacts.Items.RemoveAt(Lb_AllContacts.SelectedIndex);
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }
        //Add contact      
        Contact contact;
        private void Bt_Add_Click(object sender, EventArgs e)
        {
            contact = new Contact();
            Child addform = new Child(contact, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {
                Lb_AllContacts.Items.Add(contact);
                pictureBox1.Load(contact.Path);
            }

        }
        //Edit contact
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            //редактирование контакта
            if (Lb_AllContacts.SelectedIndex == -1)//Если контакт не выбран
            {
                MessageBox.Show("You have not selected a contact"); return;
            }

            int n = Lb_AllContacts.SelectedIndex;//запоминаем выделенный элемент
            contact = (Contact)Lb_AllContacts.Items[n];//Забираем ссылку на выделенный элемент

            Child editform = new Child(contact, false);
            editform.ShowDialog();
            Lb_AllContacts.Items.RemoveAt(n);//Удаляем выделенный элемент
            Lb_AllContacts.Items.Insert(n, contact);//и добавляем его снова в ту же позицию, чтобы он перерисовался в списке
            Lb_AllContacts.SelectedIndex = n; //Снова выделяем этот элемент
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Lb_AllContacts.SelectedIndex;//запоминаем выделенный элемент
            contact = (Contact)Lb_AllContacts.Items[n];//Забираем ссылку на выделенный элемент
            pictureBox1.Load(contact.Path);
        }
    }
}
