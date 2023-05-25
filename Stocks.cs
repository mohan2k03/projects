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
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
            displayStocks();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\mohan2003_\OneDrive\Documents\GarageDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void displayStocks()
        {
            con.Open();
            String Query = "select * from StockTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StocksDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (PartNameTB.Text == "" || QuantityTB.Text == "" || PartPriceTB.Text == "")
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StockTable(PartName, Quantity, PartPrice) values(@PN, @PQ, @PP)", con);
                    cmd.Parameters.AddWithValue("@PN", PartNameTB.Text);
                    cmd.Parameters.AddWithValue("@PQ", QuantityTB.Text);
                    cmd.Parameters.AddWithValue("@PP", PartPriceTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Part Added in Stock.....");
                    con.Close();
                    displayStocks();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void StocksDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PartNameTB.Text = StocksDGV.SelectedRows[0].Cells[1].Value.ToString();
            QuantityTB.Text = StocksDGV.SelectedRows[0].Cells[2].Value.ToString();
            PartPriceTB.Text = StocksDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (PartNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StocksDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Part");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from StockTable where PartID=@PID", con);
                    cmd.Parameters.AddWithValue("@PID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Part Deleted");
                    con.Close();
                    displayStocks();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (PartNameTB.Text == "" || QuantityTB.Text == "" || PartPriceTB.Text == "")
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update StockTable set PartName=@PN, Quantity=@PQ, PartPrice=@PP, where PartID=@PID", con);
                    cmd.Parameters.AddWithValue("@PID", key);
                    cmd.Parameters.AddWithValue("@PN", PartNameTB.Text);
                    cmd.Parameters.AddWithValue("@PQ", QuantityTB.Text);
                    cmd.Parameters.AddWithValue("@PP", PartPriceTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Part Updated.....");
                    con.Close();
                    displayStocks();
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

        private void StockLabel_Click(object sender, EventArgs e)
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
