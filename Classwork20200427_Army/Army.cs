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

namespace Classwork20200427_Army
{
    public partial class Army : Form
    {
        List<Unit> army;
      
        public Army()
        {
            InitializeComponent();
            army = new List<Unit>()
           {
                new Unit { Name = "Swordsman" },
                new Unit { Name = "Archer" },
                new Unit { Name = "Mage" }

            };
            Lb_All.DataSource = army;
            Lb_All.DisplayMember = "Name";
            

        }
       
        private void Bt_Add_One_Click(object sender, EventArgs e)
        {
           
            if (Lb_All.SelectedIndex == -1)
                return;

            if (Lb_One.Items.Count == numericUpDown1.Value)
                return;

            Unit temp = Lb_All.SelectedItem as Unit;
               Lb_One.Items.Add(temp.Name);
            

        }

        private void Bt_Add_Two_Click(object sender, EventArgs e)
        {
            if (Lb_All.SelectedIndex == -1)
                return;

            if (Lb_Two.Items.Count == numericUpDown1.Value)
                return;

            Unit temp = Lb_All.SelectedItem as Unit;
            Lb_Two.Items.Add(temp.Name);
        }

        private void Rb_One_CheckedChanged(object sender, EventArgs e)
        {
         
            Lb_Select_Team.Items.Clear();

            if (Rb_One.Checked)
            {
                Lb_Team.Text = "You selected command One";
                Lb_Select_Team.Items.AddRange(Lb_One.Items);
            }

            else
            {
                Lb_Team.Text = "You selected command Two";
                Lb_Select_Team.Items.AddRange(Lb_Two.Items);
            }
            
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {

            Lb_One.Items.Clear();
            Lb_Two.Items.Clear();
            Lb_Select_Team.Items.Clear();
            Lb_Team.Text = String.Empty;

            if (Rb_One.Checked)
            {
                Rb_One.Checked = false;
            }
            if (Rb_Two.Checked)
            {
                Rb_Two.Checked = false;
            }
        }

        private void Add_File_One_Click(object sender, EventArgs e)
        {
            if (Lb_One.Items.Count == 0)
            {
                MessageBox.Show("Create a group");
                return;
            }
            List<Unit>temp = new List<Unit>();

            
            for (int i = 0; i < Lb_One.Items.Count; i++)
            {
                temp.Add(new Unit { Name = Lb_One.Items[i].ToString() });
            }

            string file = @"D:\Folder\Team_One.xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Unit>));
            Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            xml.Serialize(stream, temp);
            stream.Close();
            MessageBox.Show("File.xls \"Team_One\" saved !");


        }

        private void Add_File_Two_Click(object sender, EventArgs e)
        {
            if (Lb_Two.Items.Count == 0)
            {
                MessageBox.Show("Create a group");
                return;
            }

            List<Unit> temp = new List<Unit>();

            for (int i = 0; i < Lb_Two.Items.Count; i++)
            {
                temp.Add(new Unit { Name = Lb_Two.Items[i].ToString() });
            }


            string file = @"D:\Folder\Team_Two.xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Unit>));
            Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            xml.Serialize(stream, temp);
            stream.Close();
            MessageBox.Show("File.xls \"Team_Two\" saved !");

        }

        private void Bt_Delete_Unit_Click(object sender, EventArgs e)
        {
            if (Lb_One.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Unit");
                return;
            }

            if (Lb_One.SelectedIndex != 0)
            {
                Lb_One.Items.RemoveAt(Lb_One.SelectedIndex);

            }

           

        }

        private void Bt_Delete_Two_Click(object sender, EventArgs e)
        {
            if (Lb_Two.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Unit");
                return;
            }

            if (Lb_Two.SelectedIndex != 0)
            {
                Lb_Two.Items.RemoveAt(Lb_Two.SelectedIndex);

            }
        }
    }
}
