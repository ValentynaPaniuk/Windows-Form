using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200416_AZS
{
    public partial class AZS : Form
    {
        const decimal Gazoline = 25, Gas = 10, Disiel = 20;
        decimal Price = 0;
        decimal Cost_of_fuel = 0;

        decimal Tea = 20;
        decimal Coffee = 25;
        decimal Coffee_with_Milk = 25;
        decimal Cappuccino = 30;

        decimal Hotdog = 50;
        decimal Juice = 30;
        decimal Sandwich = 40;

       

        public AZS()
        {
            InitializeComponent();
            Cb_Fuel.Focus();
            Lb_Fuel.Text = $"Gazoline: {Gazoline}      Gas: {Gas}        Disiel: {Disiel}";
            Tb_Tea.Text = Tea.ToString();
            Tb_Coffee.Text = Coffee.ToString();
            Tb_Coffee_with_milk.Text = Coffee_with_Milk.ToString();
            Tb_Cappuccino.Text = Cappuccino.ToString();
            Tb_HotDog.Text = Hotdog.ToString();
            Tb_Juice.Text = Juice.ToString();
            Tb_Sandwich.Text = Sandwich.ToString();
           
        }

        private void Cb_Fuel_TextChanged(object sender, EventArgs e)
        {
            Cb_Fuel.Focus();
            Lb_type.Text = $"You have chosen: {Cb_Fuel.Text}";
            

        }
             

        
        private void Nud_Fuel_ValueChanged(object sender, EventArgs e)
        {
            Lb_volume.Text = $"You have selected {Nud_Fuel.Value} liters";
            if (Cb_Fuel.Text == String.Empty || Nud_Fuel.Value == 0)
            {
                MessageBox.Show("Check fuel type and volume input");
                Cb_Fuel.Focus();
                Nud_Fuel.Value = 0;
                return;
            }


          
            Choose_fuel();

            Cost_of_fuel = Price * Nud_Fuel.Value;
            Tb_cost_fuel.Text = Cost_of_fuel.ToString();
        }

        //Не дозволяє вводити цифри
        private void Tb_cost_fuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (Char)Keys.Back == e.KeyChar) return;
            else
                e.Handled = true;
           
        }

        private void Btn_Account_Click(object sender, EventArgs e)
        {
            string address = "AZS №10 Soborna st.18, Rivne";
            Lb_Account.Items.Add(address);
            AZS.ActiveForm.Height = 500;
            Lb_total_Account.Text = String.Empty;
            Lb_total_Account.Text += Lb_total.Text;
            Lb_Account.Items.Add(Lb_total_Account.Text);
            Lb_total_Account.Text = String.Empty;
          

            if (Cb_Tea.Checked && Nup_Tea.Value == 0 || Cb_Coffee.Checked && Nup_Coffee.Value == 0 || Cb_Cappuccino.Checked && Nup_Cappuccino.Value == 0 || Cb_CoffeeMilk.Checked && Nup_CoffeWithMilk.Value == 0 || Cb_Sandwich.Checked && Nup_Sandwich.Value == 0  || Cb_HotDog.Checked && Nup_Hotdog.Value == 0 || Cb_Juice.Checked && Nup_Juice.Value == 0)
            {
                MessageBox.Show("Please check your order carefully 1");
                Lb_Account.Items.Clear();
                return;
            }

            else if (Cb_Tea.Checked == false && Nup_Tea.Value != 0 || Cb_Coffee.Checked == false && Nup_Coffee.Value != 0 || Cb_Cappuccino.Checked == false && Nup_Cappuccino.Value != 0 || Cb_CoffeeMilk.Checked == false && Nup_CoffeWithMilk.Value != 0 || Cb_Sandwich.Checked == false && Nup_Sandwich.Value != 0 || Cb_HotDog.Checked == false && Nup_Hotdog.Value != 0 || Cb_Juice.Checked == false && Nup_Juice.Value != 0)
            {
                MessageBox.Show("Please check your order carefully 2");
                Lb_Account.Items.Clear();
                return;
            }

           

            if (Cb_Tea.Checked && Nup_Tea.Value != 0)
            {
                Lb_total_Account.Text += $"{Cb_Tea.Text} {Tea} * {Nup_Tea.Value} = {Tea * Nup_Tea.Value}";
                Lb_Account.Items.Add(Lb_total_Account.Text);
            }
            if (Cb_Coffee.Checked && Nup_Coffee.Value != 0)
            {
               Lb_total_Account.Text = $"{Cb_Coffee.Text} {Coffee} * {Nup_Coffee.Value} = {Coffee * Nup_Coffee.Value}";
                Lb_Account.Items.Add(Lb_total_Account.Text);
            }
            if (Cb_Cappuccino.Checked && Nup_Cappuccino.Value != 0)
            {
                Lb_total_Account.Text = $"{Cb_Cappuccino.Text} {Cappuccino} * {Nup_Cappuccino.Value} = {Cappuccino * Nup_Cappuccino.Value}";
                Lb_Account.Items.Add(Lb_total_Account.Text);
            }

            if (Cb_CoffeeMilk.Checked && Nup_CoffeWithMilk.Value != 0)
            {
                Lb_total_Account.Text = $"{Cb_CoffeeMilk.Text} {Coffee_with_Milk} * {Nup_CoffeWithMilk.Value} = {Coffee_with_Milk * Nup_CoffeWithMilk.Value}";
                Lb_Account.Items.Add(Lb_total_Account.Text);
            }

            if (Cb_Sandwich.Checked && Nup_Sandwich.Value != 0)
            {
                Lb_total_Account.Text = $"{Cb_Sandwich.Text} {Sandwich} * {Nup_Sandwich.Value} = {Sandwich * Nup_Sandwich.Value}";
                Lb_Account.Items.Add(Lb_total_Account.Text);
            }

            if (Cb_HotDog.Checked && Nup_Hotdog.Value != 0)
            {
                Lb_total_Account.Text = $"{Cb_HotDog.Text} {Hotdog} * {Nup_Hotdog.Value} = {Hotdog * Nup_Hotdog.Value}";
                Lb_Account.Items.Add(Lb_total_Account.Text);
            }

            if (Cb_Juice.Checked && Nup_Juice.Value != 0)
            {
                Lb_total_Account.Text = $"{Cb_Juice.Text} {Juice} * {Nup_Juice.Value} = {Juice * Nup_Juice.Value}";
                Lb_Account.Items.Add(Lb_total_Account.Text);
            }

            Lb_Account.Items.Add(DateTime.Now);
            Lb_Account.Show();
            Lb_Advertising.Text = "Thank you for your purchase! The motto of your day: Everything will be fine!!! And even better !!!";
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {
            Lb_Account.Items.Clear();

            Cb_Fuel.Text = "Type of fuel";
            Tb_cost_fuel.Text = String.Empty;
            Nud_Fuel.Value = 0;

            Lb_Advertising.Text = null;


            foreach (var item in panel2.Controls)
            {
                if (item is CheckBox)
                {
                    Cleare_CB(item);
                }
            }

            foreach (var item in panel2.Controls)
            {
                if (item is NumericUpDown)
                {
                    Cleare_NUD(item);
                }
            }

        }

        private void Cleare_CB(Object Cb)
        {
            (Cb as CheckBox).Checked = false;
          
        }

        private void Cleare_NUD(Object Nud)
        {
            (Nud as NumericUpDown).Value = 0;
        }

        private void Cb_Fuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Choose_fuel();
            Tb_price.Text = Price.ToString();
            Lb_Price.Text = $"Price: {Price} GRN";
        }

        private void Btn_total_fuel_Click(object sender, EventArgs e)
        {
            string result = $"FUEL: {Cb_Fuel.Text} VOLUME: {Nud_Fuel.Value} lit. PRICE: {Price} GRN \nTOTAL: {Cost_of_fuel} GRN";
            panel1.Height = 261;
            Lb_total.Text = result;
            Lb_total.Visible = true;
    

        }

        

        private void Tb_cost_fuel_TextChanged(object sender, EventArgs e)
        {
            
            if (Cb_Fuel.Text == "Type of fuel"  || Cb_Fuel.Text == String.Empty)
            {
                             
                MessageBox.Show("Check fuel type");
                return;
            }

            Choose_fuel();

            Nud_Fuel.Value = Convert.ToDecimal(Tb_cost_fuel.Text) / Price;
         
        }

        private void Choose_fuel()
        {
              if (Cb_Fuel.Text == "Gazoline" && Nud_Fuel.Value == 0)
            {
                Price = Gazoline;

            }
            else if (Cb_Fuel.Text == "Gas" && Nud_Fuel.Value == 0)
            {
                Price = Gas;

            }
            else if (Cb_Fuel.Text == "Disiel" && Nud_Fuel.Value == 0)
            {
                Price = Disiel;

            }
        }

      
    }
}
