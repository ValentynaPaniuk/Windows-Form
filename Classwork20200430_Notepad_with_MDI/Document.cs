using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200430_Notepad
{


  
    public partial class Document : Form
    {
        
        //Порожній конструктор
        public Document()  {     InitializeComponent();        }

        //Відкрита властивість Richtextbox
        public RichTextBox Richtextbox
        {
            get { return this.richTextBox1; }
            set { richTextBox1 = value; }
        }


        //Перегружений конструктор
        public Document(RichTextBox x)
        {
            InitializeComponent();
            richTextBox1 = x;
        }

        //Перегружений метод Show
        public void Show(RichTextBox x)
        {
            richTextBox1 = x;
            Show();
        }
        //При закритті дочірних вікон вони будуть зникати з мені View
        private void Document_FormClosing(object sender, FormClosingEventArgs e)
        {
            string title = this.Text;

            var puncts = ((Notepad)this.MdiParent).WindowPunct.DropDownItems; // доступ до всіх пунктів меню Window
            for (int i = 0; i < puncts.Count; i++)
            {
                if (puncts[i].Text.Equals(title))
                {
                    puncts.RemoveAt(i);
                    break;
                }
            }
            if (puncts.Count == Classwork20200430_Notepad.Notepad.COUNT_PUNCTS)
            {
                puncts.RemoveAt(puncts.Count - 1);
            }
        }
    }
}
