using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200407_Mouse_Label
{
    public partial class my_form : Form
    {
        bool isTimerEnabled = false;
        public my_form()
        {
            InitializeComponent();
        }

        int i = 0;
        private void timer_Tick(object sender, EventArgs e)
        {

            this.Text = $"Label move coords: {lbl_run.Location}; ClientSize height: {ClientSize.Height} weight {ClientSize.Width}";

            lbl_run.Text = ++i + " s";
            int max_withs = this.ClientSize.Width;
            int max_heights = this.ClientSize.Height;
            Point point = lbl_run.Location;

            if (point.X < (max_withs - point.X / 9) && point.Y == 0)
                lbl_run.Location = new Point(point.X += 10, point.Y);// рух вправо

            else if (point.X > (max_withs - point.X / 9) && point.Y < (max_heights - point.Y / 1.6))
                lbl_run.Location = new Point(point.X, point.Y += 10); // рух вниз

            else if (point.Y >= (max_heights - point.Y / 1.6))
                lbl_run.Location = new Point(point.X -= 10, point.Y); // рух вліво

            if (point.X <= 0)
                lbl_run.Location = new Point(point.X, point.Y -= 10);  // рух вгору


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
            this.lbl_run.Visible = true;

            if (!isTimerEnabled)
            {
                timer.Start();                //timer.Enabled = true;
                
            }
           
            isTimerEnabled = !isTimerEnabled;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
             if (!isTimerEnabled)
                timer.Enabled = false;     //timer.Stop();
            isTimerEnabled = !isTimerEnabled;
        }

        private void lbl_run_Click(object sender, EventArgs e)
        {

        }
    }
}
