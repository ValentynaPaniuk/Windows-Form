using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200413_Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
            Tb_actions.Focus();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            
             if (Tb_actions.Text == "0" && Tb_actions.Text != null)
            {
                Tb_actions.Text = Tb_actions.Text.Remove(0, 1);
                Tb_actions.Text += (sender as Button).Text;
            }
            else
            {
                Tb_actions.Text = Tb_actions.Text + (sender as Button).Text;
            }

                       

        }
        double a = 0, b = 0, c = 0;

        private void Btn_equel_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(Tb_actions.Text);
            switch (znak)
            {
                case '+':
                    c = a + b;

                    break;
                case '-':
                    c = a - b;
                    break;
                case '/':
                    if (b != 0)
                    { c = a / b; }
                    else
                    {
                        MessageBox.Show("it is not possible to divide by zero");
                    }
                    break;
                case '*':
                    c = a * b;
                    break;
            }
            Tb_actions.Text = c.ToString();

        }

        private void Btn_c_Click(object sender, EventArgs e)
        {
            Tb_actions.Clear();
        }

        private void Btn_change_sign_Click(object sender, EventArgs e)
        {
            if (Tb_actions.Text != "")
            {
                if (Tb_actions.Text[0] == '-')
                {
                    Tb_actions.Text = Tb_actions.Text.Remove(0, 1);
                }
                else
                {
                    Tb_actions.Text = '-' + Tb_actions.Text;

                }
            }
        }

        private void Btn_Backspace_Click(object sender, EventArgs e)
        {
            if (Tb_actions.Text != "")
                Tb_actions.Text = Tb_actions.Text.Remove(Tb_actions.Text.Length - 1, 1);
        }



        private void Btn_addition_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Tb_actions.Text);
            znak = (sender as Button).Text[0];
            Tb_actions.Clear();
            Tb_actions.Focus();
        }

        private void Btn_equel_KeyUp(object sender, KeyEventArgs e)
        {
            b = Convert.ToDouble(Tb_actions.Text);
            switch (e.KeyValue)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '/':
                    if (b != 0)
                    { c = a / b; }
                    else
                    {
                        MessageBox.Show("it is not possible to divide by zero");
                    }
                    break;
                case '*':
                    c = a * b;
                    break;
            }
            Tb_actions.Text = c.ToString();

        }

        char znak = '+';

       private void Tb_actions_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = !char.IsDigit((char)e.KeyValue);//працює
            
        }



    }           

          

        
    
}
