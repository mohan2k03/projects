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
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
            displayVehicles();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\mohan2003_\OneDrive\Documents\GarageDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void displayVehicles()
        {
            con.Open();
            String Query = "select * from VehicleTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VehicleDGV.DataSource= ds.Tables[0];
            con.Close();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(VehicleNumTB.Text=="" || VehicleBrandTB.Text=="" || VehicleModelTB.Text=="" || VehicleColourTB.Text=="" || VehicleOwnerTB.Text=="")
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd =new SqlCommand("insert into VehicleTable(VNum, VBrand, VModel, VDate, VColour, VOwner) values(@VN, @VB, @VM, @VD, @VC, @VO)", con);
                    cmd.Parameters.AddWithValue("@VN", VehicleNumTB.Text);
                    cmd.Parameters.AddWithValue("@VB", VehicleBrandTB.Text);
                    cmd.Parameters.AddWithValue("@VM", VehicleModelTB.Text);
                    cmd.Parameters.AddWithValue("@VD", VehicleDate.Value.Date);
                    cmd.Parameters.AddWithValue("@VC", VehicleColourTB.Text);
                    cmd.Parameters.AddWithValue("@VO", VehicleOwnerTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Registered.....");
                    con.Close();
                    displayVehicles();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        string VehicleKey = "";
        private void VehicleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VehicleNumTB.Text = VehicleDGV.SelectedRows[0].Cells[0].Value.ToString();
            VehicleKey = VehicleDGV.SelectedRows[0].Cells[0].Value.ToString();
            VehicleBrandTB.Text = VehicleDGV.SelectedRows[0].Cells[1].Value.ToString();
            VehicleModelTB.Text = VehicleDGV.SelectedRows[0].Cells[2].Value.ToString();
            VehicleDate.Text = VehicleDGV.SelectedRows[0].Cells[3].Value.ToString();
            VehicleColourTB.Text = VehicleDGV.SelectedRows[0].Cells[4].Value.ToString();
            VehicleOwnerTB.Text = VehicleDGV.SelectedRows[0].Cells[5].Value.ToString();
            /*if (VehicleNumTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(VehicleDGV.SelectedRows[0].Cells[0].Value.ToString());
            }*/
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (VehicleKey == "")
            {
                MessageBox.Show("Select the car");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from VehicleTable where VNum=@VN", con);
                    cmd.Parameters.AddWithValue("@VN", VehicleKey);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Deleted");
                    con.Close();
                    displayVehicles();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (VehicleNumTB.Text == "" || VehicleBrandTB.Text == "" || VehicleModelTB.Text == "" || VehicleColourTB.Text == "" || VehicleOwnerTB.Text == "")
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update VehicleTable set VBrand=@VB, VModel=@VM, VDate=@VD, VColour=@VC, VOwner=@VO where VNum=@VN", con);
                    cmd.Parameters.AddWithValue("@VN", VehicleNumTB.Text);
                    cmd.Parameters.AddWithValue("@VB", VehicleBrandTB.Text);
                    cmd.Parameters.AddWithValue("@VM", VehicleModelTB.Text);
                    cmd.Parameters.AddWithValue("@VD", VehicleDate.Value.Date);
                    cmd.Parameters.AddWithValue("@VC", VehicleColourTB.Text);
                    cmd.Parameters.AddWithValue("@VO", VehicleOwnerTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Updated.....");
                    con.Close();
                    displayVehicles();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void Billing_Click(object sender, EventArgs e)
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

        private void VehicleLabel_Click(object sender, EventArgs e)
        {
            Vehicle obj = new Vehicle();
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
