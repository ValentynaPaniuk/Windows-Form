using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Classwork20200408_Event_Planning
{

    public partial class form_planning : Form
    {
        Label planing_event = new Label();
        public form_planning()
        {
            InitializeComponent();
        
           
        }

        private void btn_addEvent_Click(object sender, EventArgs e)
        {
            
            planing_event.Text = $"{dateTimePicker.Text} Priority: {tb_priority.Text} Event: {tb_event.Text} Place {tb_plaсe.Text}";
            listBox.Items.Add(planing_event.Text);
        }


        private void tb_event_Click(object sender, EventArgs e)
        {
            tb_event.Text = String.Empty;
                     

        }

        private void tb_plaсe_Click(object sender, EventArgs e)
        {
            tb_plaсe.Text = String.Empty;
            if (String.IsNullOrWhiteSpace(tb_event.Text))
            {
                this.tb_event.Focus();
                MessageBox.Show("!!! Enter the event in the previous box");
            }
        }

        private void tb_priority_Click(object sender, EventArgs e)
        {
            tb_priority.Text = string.Empty;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "high",
                "low",
                "middle",

            };
            tb_priority.Text = "middle";
            tb_priority.AutoCompleteCustomSource = source;
            tb_priority.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_priority.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("!!! Choose the correct event time");
            }
        }

        private void btn_cleare_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            

        }

        private void form_planning_Load(object sender, EventArgs e)
        {
            tb_event.Focus();
        }
    }
}
