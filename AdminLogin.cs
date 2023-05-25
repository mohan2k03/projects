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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(AdminPasswordTB.Text == "")
            {
                MessageBox.Show("Enter the password *_*");
            }
            else if (AdminPasswordTB.Text == "Bre@thless1")
            {
                Employee obj = new Employee();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password-_-");
            }
        }
    }
}
