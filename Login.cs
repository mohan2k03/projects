using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Garage_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\mohan2003_\OneDrive\Documents\GarageDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public static string Username = "";
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Enter UserName and Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeTable Where EmpName = '"+UserTB.Text+"'and EmpPass='"+PasswordTB.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Username = UserTB.Text;
                    Billing obj = new Billing();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or password =_=");
                }
                con.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Hide();
        }
    }
}
