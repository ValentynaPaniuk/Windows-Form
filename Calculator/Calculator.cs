using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        double x  , y , z  ;
        char znak = '+';
        //Додаємо число кожної кнопки до TextBox1
        private void button17_Click(object sender, EventArgs e)
        {

          
            ////Якщо перше число 0 і потім тиснути "," нуль не стирається
            if (textBox1.Text.Length == 1 && textBox1.Text == "0" && (sender as Button).Text == ",")
            {
                textBox1.Text += ",";
            }

            ////Перевірка на кількість ком
            if (textBox1.Text.Contains(",") && (sender as Button).Text == ",")
                return;

            if (textBox1.Text == "0" && textBox1.Text != null && textBox1.Text.Length == 1)
            {

                textBox1.Text = textBox1.Text.Remove(0, 1);
                textBox1.Text += (sender as Button).Text;

            }
            else
            {
                textBox1.Text = textBox1.Text + (sender as Button).Text;
            }

            label1.Text = textBox1.Text;
        }

        
        //Обробляємо знак "="
        private void button19_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            label1.Text = x.ToString() + znak + y;

            switch (znak)
            {
                case '+':
                    {
                        z = x + y;
                        label1.Text = x.ToString() + znak + y.ToString() + " = " + z.ToString();
                        break;
                    }
                case '-':
                    {
                        z = x - y;
                        label1.Text = x.ToString() + znak + y.ToString() + " = " + z.ToString();
                        break;
                    }
                case '*':
                    {
                        z = x * y;
                        label1.Text = x.ToString() + znak + y.ToString() + " = " + z.ToString();
                        break;
                    }
                case '/':
                    {
                        if (y == 0)
                        {
                            MessageBox.Show("It is not possible to divide by zero");
                        }
                        z = x / y;
                        label1.Text = x.ToString() + znak + y.ToString() + " = " + z.ToString();
                        break;
                    }
             
            }
            textBox1.Text = z.ToString();
           

        }

        //Видаляємо все в textBox1
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            label1.Text = String.Empty;
            textBox1.Focus();
           
        }

        //Міняємо знак числа
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1); // видаляється перший символ
                else textBox1.Text = '-' + textBox1.Text;

            label1.Text = textBox1.Text;
        }


        //Видалення останнього символу
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);//Видалення останнього символу
            label1.Text = textBox1.Text;
            
        }

      
        //Записуємо число в змінну Х і записуємо дію в znak 
        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
          
            znak = (sender as Button).Text[0]; //тому що char
            label1.Text = x.ToString() + znak;
            textBox1.Clear(); 
        }

        //Визначає точний час
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.UtcNow.ToString(); //Представленное время является временем UTC(Всемирное координированное время)

        }

        //Чи точно плануєте не працювати з калькулятором
        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  MessageBox.Show("Are You Sure?");
        }


        /////===============================================================================


        //Перевірка на правльність введення числа
        //Булевий прапор, який використовується для визначення часу, коли вводиться символ, який не є числом.
        private bool nonNumberEntered = false;
      
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           //  Text = e.KeyCode.ToString();

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox1.Text);

            label1.Text = ($"{ x.ToString()}     {e.KeyCode}     { y.ToString()} =   { z.ToString()}");
            try
            {
                switch (e.KeyCode)
                {

                    case Keys.Add:
                        {
                            
                            z = x + y;
                            MessageBox.Show($"{x} {e.KeyCode} {y} {z}");
                            break;
                        }
                    case Keys.Subtract:
                        {
                            z = x - y;
                            break;
                        }
                    case Keys.Multiply:
                        {
                            z = x * y;

                            break;
                        }
                    case Keys.Divide:
                        {
                            if (y == 0)
                            {
                                MessageBox.Show("It is not possible to divide by zero");
                            }
                            z = x / y;

                            break;
                        }
                    case Keys.Delete:
                        {
                            textBox1.Text = String.Empty;
                            label1.Text = String.Empty;
                            textBox1.Text = "0";
                            textBox1.Focus();
                            break;
                        }



                }


                if (e.KeyCode == Keys.Return)
                {
                    textBox1.Text = z.ToString();
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show($"We have problem ... {ex.Message}");
            }

        }



        //

        // Оброблена подія KeyDown, щоб визначити тип символу, введеного в елемент управління.
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //Ініціалізуйте прапор на false.
            nonNumberEntered = false;

          

            // Визначте, чи натискання клавіші є цифрою вгорі клавіатури.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9 || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide)
            {
                // Визначте, чи є натисканням клавіші число з клавіатури.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9 || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide)
                {
                    // Визначте, чи натиснута клавіша backspace.
                    if (e.KeyCode != Keys.Back)
                    {

                        // Була натиснута нечислова клавіша.
                        // Встановіть прапор у значення true та оцініть у події KeyPress.
                        nonNumberEntered = true;
                    }
                    
                }
            }
            //Якщо була натиснута клавіша shift, це не число.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
               
            }

            
        }

        //Ця подія відбувається після події KeyDown і може бути використана для запобігання входу символів до елемента керування
        
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Перевірте, чи встановлений прапор у події KeyDown.
            if (nonNumberEntered == true)
            {
                // Не допускайте введення символу до елемента керування, оскільки воно не є числовим.
                 e.Handled = true;
            }





        }


    }
}
