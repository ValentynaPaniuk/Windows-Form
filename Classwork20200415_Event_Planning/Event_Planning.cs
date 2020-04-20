using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200415_Event_Planning
{
    public partial class Form1 : Form
    {
        Event myevent = new Event();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("!!! Choose the correct event time");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Lb_Priority.Text = " "+ (sender as RadioButton).Text;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {



            myevent.Name = textBox1.Text;
            myevent.DateTime = dateTimePicker1.Value;
           
                     
            foreach (Control item in this.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton temp = item as RadioButton;

                    if (temp.Checked)
                        myevent.Priority = temp.Text;

                }
                else
                    myevent.Priority = radioButton2.Text;

            }
           
            ClbExample.Items.Add(myevent.ToString());
            textBox1.Text = "";
            textBox1.Focus();


        }

        private void Bt_Cleare_Click(object sender, EventArgs e)
        {
            while (ClbExample.CheckedIndices.Count != 0)
                ClbExample.Items.RemoveAt(ClbExample.CheckedIndices[0]); // 1 2 3
           
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            ClbExample.Items.Clear();
        }

        private void Bt_Search_Click(object sender, EventArgs e)
        {
          
             
           
        }
    }
    
}
