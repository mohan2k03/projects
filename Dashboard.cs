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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountVehicles();
            CountEmployees();
            CountStock();
            SumAmount();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\mohan2003_\OneDrive\Documents\GarageDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void CountVehicles()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from VehicleTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Vehicle.Text = dt.Rows[0][0].ToString();
        }

        private void CountEmployees()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Mechanic.Text = dt.Rows[0][0].ToString();
        }

        private void CountStock()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from StockTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Spare.Text = dt.Rows[0][0].ToString();
        }

        private void SumAmount()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(TotalFees) from BillingTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Amount.Text ="Rs"+ dt.Rows[0][0].ToString();
        }

        private void VehicleLabel_Click(object sender, EventArgs e)
        {
            Vehicle obj = new Vehicle();
            obj.Show();
            this.Hide();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            Stocks obj = new Stocks();
            obj.Show();
            this.Hide();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }

        private void BillingLabel_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }

        private void Analytics_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
