using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Garage_Management_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        int StartPoint = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            StartPoint += 1;
            MyProgressBar.Value = StartPoint;
            Percentage.Text = StartPoint + "%";
            if (MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}
