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

    public partial class Form_planning : Form
    {
        EventList list = new EventList();
        public Form_planning()
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
            tb_event.Text = String.Empty;
        }

        private void tb_plaсe_Click(object sender, EventArgs e)
        {
            tb_plaсe.Text = String.Empty;
            if (String.IsNullOrWhiteSpace(tb_event.Text))
            {
                MessageBox.Show("!!! Enter the event in the previous box");
                this.tb_event.Focus();
            }
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
            list.Clear();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string file = dateTimePicker.Value.ToShortDateString() + "_EventPlanner" + ".xml";
            XmlSerializer xml = new XmlSerializer(list.GetType());  // typeof(EventList)
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, list);
            }
            MessageBox.Show("Completed!");
        }
        private void bt_save_ClickByDate(object sender, EventArgs e)
        {
            string file = dateTimePicker.Value.ToShortDateString() + "_EventPlanner" + ".xml";
            List<Event> temp = (from i in list.Events
                                where i.DateTime == dateTimePicker.Value
                                select i).ToList();
            EventList tempList = new EventList();
            foreach (var item in temp)
            {
                tempList.AddEvent(item);
            }
            XmlSerializer xml = new XmlSerializer(tempList.GetType());  // typeof(EventList)
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, tempList);
            }
            MessageBox.Show("Completed!");
        }
        private void form_planning_Load(object sender, EventArgs e)
        {
            tb_event.Focus();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(EventList));
            string file = dateTimePicker.Value.ToShortDateString() + "_EventPlanner" + ".xml";
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                // Десеріалізація - отримуємо ОБ'ЄКТ з файла
                list = (EventList)xml.Deserialize(stream);
            }
            MessageBox.Show("Completed!");
            ShowInListBox();

        }
        private void SaveAsJson()
        {
            
        }
        private void ShowInListBox()
        {
            listBox.Items.Clear();
            foreach (var item in list.Events)
            {
                listBox.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.SaveToJson();
        }
    }
}
