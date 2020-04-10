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
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Classwork20200409_Student
{

    public partial class Form : System.Windows.Forms.Form
    {
     

        public List<Student> List { get; set; } = new List<Student>();

        
        public Form()
        {
            InitializeComponent();
        }

      

        private void Btn_add_student_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Birthday = DateTimePicker_birthday.Value,
                Name = Tb_name.Text,
                Surname = Tb_surname.Text,
                Hobby = Tb_hobby.Text
            };

            if (ComboBox.SelectedItem != null)
                student.Gender = ComboBox.SelectedItem.ToString();
            else
                student.Gender = "Male";

            List.Add(student);
            ListBox_add_student.Items.Add(student);   

        }

        private void Tb_name_Click(object sender, EventArgs e)
        {
            Tb_name.Text = String.Empty;
        }

        private void Tb_surname_Click(object sender, EventArgs e)
        {
            Tb_surname.Text = String.Empty;
        }

        private void Tb_hobby_Click(object sender, EventArgs e)
        {
            Tb_hobby.Text = String.Empty;
        }

        //Show Age
        int year;
        private void DateTimePicker_birthday_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePicker_birthday.Value> DateTime.Now)
            {
                MessageBox.Show("!!! Choose the correct event time");
            }

            DateTime dateNow = DateTime.Now;
            year = dateNow.Year - DateTimePicker_birthday.Value.Year;
            if (dateNow.Month < DateTimePicker_birthday.Value.Month ||
                (dateNow.Month == DateTimePicker_birthday.Value.Month && dateNow.Day < DateTimePicker_birthday.Value.Day)) year--;

           Lbl_birthday.Text = $"Age: {year}";
                 

        }


        //Save XML file ALL
        private void Btn_SaveAll_Click(object sender, EventArgs e)
        {
            string file = DateTimePicker_birthday.Value.ToShortDateString() + "_All_Students" + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
            Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            xml.Serialize(stream, List);
            stream.Close();
            MessageBox.Show("File.xls \"All students\" saved !");
        }

       

        //Save XML by Surname
        private void Btn_save_by_surname_Click(object sender, EventArgs e)
        {
            string file = DateTimePicker_birthday.Value.ToShortDateString() + "_Student_" + Tb_surname.Text + ".xml";
            List<Student> temp = (from i in List
                                  where i.Surname == Tb_surname.Text
                                  select i).ToList();
            Student tempList = new Student();
            foreach (var item in temp)
            {
                tempList.Name = Tb_name.Text;
                tempList.Surname = Tb_surname.Text;
                tempList.Gender = ComboBox.Text;
                tempList.Birthday = DateTimePicker_birthday.Value;
                tempList.Hobby = Tb_hobby.Text;

            }


            XmlSerializer xml = new XmlSerializer(tempList.GetType());  // typeof(EventList)
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, tempList);
            }
            MessageBox.Show("Save by surname in file.xls!");

        }

        //Save Jason
        private void Btn_save_jason_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(List);
            File.WriteAllText("1.json", json);
            MessageBox.Show("Save as file.json!");
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            List.Clear();
            ListBox_add_student.Items.Clear();
            Tb_name.Text = String.Empty;
            Tb_surname.Text = String.Empty;
            Tb_hobby.Text = String.Empty;
        }




        //Load fron File.XML
        private void Btn_load_Click(object sender, EventArgs e)
        {
            string file = DateTimePicker_birthday.Value.ToShortDateString() + "_All_Students" + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                List = (List<Student>)xml.Deserialize(stream);
            }

            MessageBox.Show("File has loaded fron file.XML!");

            ShowInListBox();

        }



        private void ShowInListBox()
        {
            ListBox_add_student.Items.Clear();
            foreach (var item in List)
            {
                ListBox_add_student.Items.Add(item);
            }
        }

        //Load One Student from XML
        Student One = new Student();
        private void Btn_load__Click(object sender, EventArgs e)
        {
            string file = DateTimePicker_birthday.Value.ToShortDateString() + "_Student_" + Tb_surname.Text + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(Student));
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
              One = (Student)xml.Deserialize(stream);
            }

            ListBox_add_student.Items.Add(One);
            List.Add(One);
            ListBox_add_student.Show();
            Tb_name.Text = One.Name;
            Tb_surname.Text = One.Surname;
            Tb_hobby.Text = One.Hobby;
            ComboBox.Text = One.Gender;
            DateTimePicker_birthday.Value = One.Birthday;

            
            MessageBox.Show("Students date has loaded fron file.XML!");

                                 
        }

    }
}
