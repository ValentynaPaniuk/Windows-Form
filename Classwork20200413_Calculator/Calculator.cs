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
    public partial class Calc : System.Windows.Forms.Form
    {

        public Calc()
        {
            InitializeComponent();
            Tb_actions.Focus();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
               
            if (Tb_actions.Text.Length == 1)
            {
                Tb_actions.Text += ",";
            }
            if (Tb_actions.Text.Contains(",") && (sender as Button).Text == ",")
                return;
            if (Tb_actions.Text == "0" && Tb_actions.Text != null)
            {
                Tb_actions.Text = Tb_actions.Text.Remove(0, 1);
                Tb_actions.Text += (sender as Button).Text;
            }
            Tb_actions.Text = Tb_actions.Text + (sender as Button).Text;

           
                      

        }
        double a, b, c;
        char znak = '+';

        private void Btn_equel_Click(object sender, EventArgs e)
        {
           Tb_actions.Text = " ";
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
            Tb_actions.Text = "0";
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
                        MessageBox.Show("It is not possible to divide by zero");
                    }
                    break;
                case '*':
                    c = a * b;
                    break;
            }
            Tb_actions.Text = c.ToString();

        }

       

        //====================================================================================================
       

      


        //MSDN
        private bool nonNumberEntered = false;
        
        private void Tb_actions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
               e.Handled = true;
            }
        }

        private void Tb_actions_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            Text = e.KeyCode.ToString();
           
            //if (e.KeyCode == Keys.Add) //+
            //{
                
            //    Btn_addition_Click(Btn_addition, null);
            //    e.Handled = true;
            //}

          
            //if (e.KeyCode == Keys.Multiply) //*
            //{

            //    Btn_addition_Click(Btn_multiplication, null);
            //    e.Handled = true;
            //}

            //if (e.KeyCode == Keys.Subtract)  // -
            //{

            //    Btn_addition_Click(Btn_substraction, null);
            //    e.Handled = true;
            //}


            //if (e.KeyCode == Keys.Divide) // /
            //{

            //    Btn_addition_Click(Btn_division, null);
            //    e.Handled = true;
            //}

          


            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9 || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide)
            {
                
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9 || e.KeyCode == Keys.Enter || e.KeyCode ==Keys.Add || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide)
                {
                    
                    if (e.KeyCode != Keys.Back)
                    {
                                             
                        nonNumberEntered = true;
                    }
                    
                    
                }
            }
           if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }


           
        }
          

    }           
     
    
}
