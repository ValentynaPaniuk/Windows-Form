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
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Classwork20200408_Event_Planning
{

    public partial class form_planning : Form
    {
        EventList list = new EventList();
        public form_planning()
        {
            InitializeComponent();
        
           
        }

        private void btn_addEvent_Click(object sender, EventArgs e)
        {

            Event myevent = new Event
            {
                Place = tb_plaсe.Text,
                Title = tb_event.Text,
                DateTime = dateTimePicker.Value,
            };
            if (comboBox1.SelectedItem != null)
                myevent.Priority = comboBox1.SelectedItem.ToString();
            else
                myevent.Priority = "Middle";
            list.AddEvent(myevent);
            listBox.Items.Add(myevent);
        }


        private void tb_event_Click(object sender, EventArgs e)
        {
            Tb_event.Text = String.Empty;
                     

        }

        private void tb_plaсe_Click(object sender, EventArgs e)
        {
            Tb_plaсe.Text = String.Empty;
            if (String.IsNullOrWhiteSpace(Tb_event.Text))
            {
                this.Tb_event.Focus();
                MessageBox.Show("!!! Enter the event in the previous box");
            }
        }

        private void tb_priority_Click(object sender, EventArgs e)
        {
            Tb_priority.Text = string.Empty;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "high",
                "low",
                "middle",

            };
            Tb_priority.Text = "middle";
            Tb_priority.AutoCompleteCustomSource = source;
            Tb_priority.AutoCompleteMode = AutoCompleteMode.Suggest;
            Tb_priority.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("!!! Choose the correct event time");
            }
        }

        private void btn_cleare_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
            
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            

        }

        private void form_planning_Load(object sender, EventArgs e)
        {
            Tb_event.Focus();
        }
    }
}
