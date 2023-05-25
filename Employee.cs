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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            displayEmployees();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\mohan2003_\OneDrive\Documents\GarageDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void displayEmployees()
        {
            con.Open();
            String Query = "select * from EmployeeTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTB.Text == "" || EmpAddTB.Text == "" || EmpPassTB.Text == "" || EmpGen.SelectedIndex == -1)
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTable(EmpName, EmpAdd, EmpPass, EmpGen) values(@EN, @EA, @EP, @EG)", con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTB.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTB.Text);
                    cmd.Parameters.AddWithValue("@EP", EmpPassTB.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGen.SelectedItem);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Epmployee Registered.....");
                    con.Close();
                    displayEmployees();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTB.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTB.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpPassTB.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpGen.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (EmpNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Employee");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTable where EmpID=@EID", con);
                    cmd.Parameters.AddWithValue("@EID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    con.Close();
                    displayEmployees();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTB.Text == "" || EmpAddTB.Text == "" || EmpPassTB.Text == "" || EmpGen.SelectedIndex == -1)
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update EmployeeTable set EmpName=@EN, EmpAdd=@EA, EmpPass=@EP, EmpGen=@EG where EmpID=@EID", con);
                    cmd.Parameters.AddWithValue("@EID", key);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTB.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTB.Text);
                    cmd.Parameters.AddWithValue("@EP", EmpPassTB.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGen.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Information Updated.....");
                    con.Close();
                    displayEmployees();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void EmployeeLabel_Click(object sender, EventArgs e)
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
