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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            displayPart();
            GetVehicles();
            UserNameLabel.Text = Login.Username;
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\mohan2003_\OneDrive\Documents\GarageDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void GetVehicles()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select VNum from VehicleTable", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("VNum", typeof(string));
            dt.Load(dr);
            VehicleNumber.ValueMember = "VNum";
            VehicleNumber.DataSource = dt;
            con.Close();
        }
        private void displayPart()
        {
            con.Open();
            String Query = "select * from StockTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PartsDGV.DataSource = ds.Tables[0];
            con.Close();
        }
       

        int Qty=0, Price=0, key = 0;
        string PartName = "";
        private void PartsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PartName = PartsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Qty = Convert.ToInt32(PartsDGV.SelectedRows[0].Cells[2].Value.ToString());
            Price = Convert.ToInt32(PartsDGV.SelectedRows[0].Cells[3].Value.ToString());
            if (PartName == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PartsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateStock()
        {
            int newQty = Qty - Convert.ToInt32(QuantityTB.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update StockTable set Quantity=@PQ where PartID=@PID", con);
                cmd.Parameters.AddWithValue("@PID", key);
                cmd.Parameters.AddWithValue("@PQ", newQty);
                cmd.ExecuteNonQuery();
                con.Close();
                displayPart();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int n = 0, num;
        int total = 0, GrdTotal = 0;
        private void AddParts_Click(object sender, EventArgs e)
        {
            if (key == 0 || QuantityTB.Text == "")
            {
                MessageBox.Show("Select spare part to add");
            }
            else if(Convert.ToInt32(QuantityTB.Text) > Qty)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                num = Convert.ToInt32(QuantityTB.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ChangedPartDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = PartName;
                total = num * Price;
                newRow.Cells[2].Value = num;
                newRow.Cells[3].Value = Price;
                newRow.Cells[4].Value = total;
                ChangedPartDGV.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                PartFeesLabel.Text = "Rs"+ GrdTotal;
                con.Close();
                UpdateStock();
                QuantityTB.Text = "";
            }
        }

        int tf = 0;
        private void CalculateFees_Click(object sender, EventArgs e)
        {
            if (MechanicFee.Text == "")
            {
                MessageBox.Show("Enter a valid amount");
            }
            else if (PartFeesLabel.Text == "Rs0")
            {
                tf = Convert.ToInt32(MechanicFee.Text);
                TotalFeesLabel.Text ="Rs"+ Convert.ToString(MechanicFee.Text);
            }
            else
            {
                tf = GrdTotal + Convert.ToInt32(MechanicFee.Text);
                TotalFeesLabel.Text = "Rs"+ Convert.ToString(GrdTotal + Convert.ToInt32(MechanicFee.Text));
            }
        }

        private void SaveBill_Click(object sender, EventArgs e)
        {
            if (VehicleNumber.SelectedIndex == -1 || TotalFeesLabel.Text == "Rs0")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillingTable(VehicleNum, BillDate, MechFees, PartFees, TotalFees, EmpName) values(@VN, @BD, @MF, @PF, @TF, @EN)", con);
                    cmd.Parameters.AddWithValue("@VN", VehicleNumber.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@BD", BillDate.Value.Date);
                    cmd.Parameters.AddWithValue("@MF", MechanicFee.Text);
                    cmd.Parameters.AddWithValue("@PF", GrdTotal);
                    cmd.Parameters.AddWithValue("@TF", tf);
                    cmd.Parameters.AddWithValue("@EN", UserNameLabel.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved.....");
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

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
