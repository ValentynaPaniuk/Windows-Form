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

namespace Examination
{
    public partial class Test : Form
    {
        List<Questions> questions = new List<Questions>();
        public Test()
        {
            InitializeComponent();
        }


        private void Start_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Questions>));
            string file = "test"+".xml";
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                questions = (List<Questions>)xml.Deserialize(stream);
            Testing testingForm = new Testing(questions);
            DialogResult dr = testingForm.ShowDialog();

        }

      
    }
}
