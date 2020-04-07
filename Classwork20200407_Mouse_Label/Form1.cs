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
            lbl_run.Text = ++i + " s";

            Point point = lbl_run.Location;
            this.Text = $"Label move coords: {lbl_run.Location}; ClientSize height: {ClientSize.Height} weight {ClientSize.Width}";

            //lbl_run.Location = new Point(lbl_run.Location.X, lbl_run.Location.Y - 10);
            //lbl_run.Location = new Point(lbl_run.Location.X+10, lbl_run.Location.Y);


            if (point.X < ClientSize.Width - point.X / 4 && point.Y >= 0)
                lbl_run.Location = new Point(point.X += 20, point.Y); // рух вправо

           else if (point.X > ClientSize.Width - point.X && point.Y < ClientSize.Height - point.Y * 1)
                lbl_run.Location = new Point(point.X, point.Y += 20);    // рух вниз

           else if (point.X > ClientSize.Width - point.X)
                 lbl_run.Location = new Point(point.X -= 20, point.Y); // рух вліво

            //else if (point.X > ClientSize.Width - point.X / 4 && point.Y>=40)
              // lbl_run.Location = new Point(point.X, point.Y -= 20);    // рух вгору





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
