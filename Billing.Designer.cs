namespace Garage_Management_System
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.Analytics = new System.Windows.Forms.Label();
            this.BillingLabel = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.VehicleLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalFeesLabel = new System.Windows.Forms.Label();
            this.PartFeesLabel = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.SaveBill = new System.Windows.Forms.Button();
            this.TotalFee = new System.Windows.Forms.Label();
            this.ChangedPartDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartFee = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.VehicleNumber = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PartsDGV = new System.Windows.Forms.DataGridView();
            this.CalculateFees = new System.Windows.Forms.Button();
            this.AddParts = new System.Windows.Forms.Button();
            this.BillDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MechanicFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangedPartDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Magneto", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 753);
            this.panel1.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(963, 81);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(81, 22);
            this.UserNameLabel.TabIndex = 23;
            this.UserNameLabel.Text = "UserName";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.LogOutLabel);
            this.panel2.Controls.Add(this.Analytics);
            this.panel2.Controls.Add(this.BillingLabel);
            this.panel2.Controls.Add(this.Employee);
            this.panel2.Controls.Add(this.Stock);
            this.panel2.Controls.Add(this.VehicleLabel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 753);
            this.panel2.TabIndex = 3;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.ForeColor = System.Drawing.Color.Tomato;
            this.LogOutLabel.Location = new System.Drawing.Point(22, 696);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(78, 28);
            this.LogOutLabel.TabIndex = 8;
            this.LogOutLabel.Text = "LogOut";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // Analytics
            // 
            this.Analytics.AutoSize = true;
            this.Analytics.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analytics.ForeColor = System.Drawing.Color.Black;
            this.Analytics.Location = new System.Drawing.Point(22, 370);
            this.Analytics.Name = "Analytics";
            this.Analytics.Size = new System.Drawing.Size(94, 28);
            this.Analytics.TabIndex = 7;
            this.Analytics.Text = "Analytics";
            this.Analytics.Click += new System.EventHandler(this.Analytics_Click);
            // 
            // BillingLabel
            // 
            this.BillingLabel.AutoSize = true;
            this.BillingLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingLabel.ForeColor = System.Drawing.Color.White;
            this.BillingLabel.Location = new System.Drawing.Point(22, 331);
            this.BillingLabel.Name = "BillingLabel";
            this.BillingLabel.Size = new System.Drawing.Size(73, 28);
            this.BillingLabel.TabIndex = 6;
            this.BillingLabel.Text = "Billing";
            this.BillingLabel.Click += new System.EventHandler(this.BillingLabel_Click);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.ForeColor = System.Drawing.Color.Black;
            this.Employee.Location = new System.Drawing.Point(22, 289);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(102, 28);
            this.Employee.TabIndex = 5;
            this.Employee.Text = "Employee";
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.ForeColor = System.Drawing.Color.Black;
            this.Stock.Location = new System.Drawing.Point(22, 249);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(61, 28);
            this.Stock.TabIndex = 4;
            this.Stock.Text = "Stock";
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // VehicleLabel
            // 
            this.VehicleLabel.AutoSize = true;
            this.VehicleLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleLabel.ForeColor = System.Drawing.Color.Black;
            this.VehicleLabel.Location = new System.Drawing.Point(22, 204);
            this.VehicleLabel.Name = "VehicleLabel";
            this.VehicleLabel.Size = new System.Drawing.Size(79, 28);
            this.VehicleLabel.TabIndex = 3;
            this.VehicleLabel.Text = "Vehicle";
            this.VehicleLabel.Click += new System.EventHandler(this.VehicleLabel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 36);
            this.label9.TabIndex = 2;
            this.label9.Text = "Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Garage_Management_System.Properties.Resources.msg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TotalFeesLabel);
            this.panel3.Controls.Add(this.PartFeesLabel);
            this.panel3.Controls.Add(this.QuantityTB);
            this.panel3.Controls.Add(this.Quantity);
            this.panel3.Controls.Add(this.SaveBill);
            this.panel3.Controls.Add(this.TotalFee);
            this.panel3.Controls.Add(this.ChangedPartDGV);
            this.panel3.Controls.Add(this.PartFee);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.VehicleNumber);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.PartsDGV);
            this.panel3.Controls.Add(this.CalculateFees);
            this.panel3.Controls.Add(this.AddParts);
            this.panel3.Controls.Add(this.BillDate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.MechanicFee);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(213, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 632);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(720, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Customer Bill";
            // 
            // TotalFeesLabel
            // 
            this.TotalFeesLabel.AutoSize = true;
            this.TotalFeesLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFeesLabel.ForeColor = System.Drawing.Color.White;
            this.TotalFeesLabel.Location = new System.Drawing.Point(903, 543);
            this.TotalFeesLabel.Name = "TotalFeesLabel";
            this.TotalFeesLabel.Size = new System.Drawing.Size(35, 22);
            this.TotalFeesLabel.TabIndex = 33;
            this.TotalFeesLabel.Text = "Rs0";
            // 
            // PartFeesLabel
            // 
            this.PartFeesLabel.AutoSize = true;
            this.PartFeesLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartFeesLabel.ForeColor = System.Drawing.Color.White;
            this.PartFeesLabel.Location = new System.Drawing.Point(683, 543);
            this.PartFeesLabel.Name = "PartFeesLabel";
            this.PartFeesLabel.Size = new System.Drawing.Size(35, 22);
            this.PartFeesLabel.TabIndex = 32;
            this.PartFeesLabel.Text = "Rs0";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTB.Location = new System.Drawing.Point(405, 275);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(199, 28);
            this.QuantityTB.TabIndex = 31;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.Black;
            this.Quantity.Location = new System.Drawing.Point(400, 244);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(91, 28);
            this.Quantity.TabIndex = 30;
            this.Quantity.Text = "Quantity";
            // 
            // SaveBill
            // 
            this.SaveBill.AutoSize = true;
            this.SaveBill.BackColor = System.Drawing.Color.Black;
            this.SaveBill.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBill.ForeColor = System.Drawing.Color.DarkGreen;
            this.SaveBill.Location = new System.Drawing.Point(769, 577);
            this.SaveBill.Name = "SaveBill";
            this.SaveBill.Size = new System.Drawing.Size(143, 38);
            this.SaveBill.TabIndex = 29;
            this.SaveBill.Text = "Save Bill";
            this.SaveBill.UseVisualStyleBackColor = false;
            this.SaveBill.Click += new System.EventHandler(this.SaveBill_Click);
            // 
            // TotalFee
            // 
            this.TotalFee.AutoSize = true;
            this.TotalFee.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFee.ForeColor = System.Drawing.Color.White;
            this.TotalFee.Location = new System.Drawing.Point(880, 513);
            this.TotalFee.Name = "TotalFee";
            this.TotalFee.Size = new System.Drawing.Size(106, 28);
            this.TotalFee.TabIndex = 28;
            this.TotalFee.Text = "Total Fees";
            // 
            // ChangedPartDGV
            // 
            this.ChangedPartDGV.AllowUserToAddRows = false;
            this.ChangedPartDGV.AllowUserToDeleteRows = false;
            this.ChangedPartDGV.AllowUserToResizeColumns = false;
            this.ChangedPartDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            this.ChangedPartDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.ChangedPartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChangedPartDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ChangedPartDGV.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangedPartDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.ChangedPartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChangedPartDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Magneto", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangedPartDGV.DefaultCellStyle = dataGridViewCellStyle23;
            this.ChangedPartDGV.Location = new System.Drawing.Point(638, 113);
            this.ChangedPartDGV.Name = "ChangedPartDGV";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Magneto", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangedPartDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            this.ChangedPartDGV.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.ChangedPartDGV.RowTemplate.Height = 24;
            this.ChangedPartDGV.Size = new System.Drawing.Size(366, 397);
            this.ChangedPartDGV.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Part";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // PartFee
            // 
            this.PartFee.AutoSize = true;
            this.PartFee.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartFee.ForeColor = System.Drawing.Color.White;
            this.PartFee.Location = new System.Drawing.Point(657, 513);
            this.PartFee.Name = "PartFee";
            this.PartFee.Size = new System.Drawing.Size(99, 28);
            this.PartFee.TabIndex = 25;
            this.PartFee.Text = "Part Fees";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(405, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 28);
            this.label17.TabIndex = 24;
            this.label17.Text = "Date";
            // 
            // VehicleNumber
            // 
            this.VehicleNumber.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleNumber.FormattingEnabled = true;
            this.VehicleNumber.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.VehicleNumber.Location = new System.Drawing.Point(410, 113);
            this.VehicleNumber.Name = "VehicleNumber";
            this.VehicleNumber.Size = new System.Drawing.Size(148, 29);
            this.VehicleNumber.TabIndex = 23;
            this.VehicleNumber.Text = "Vehicle Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(90, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 28);
            this.label16.TabIndex = 22;
            this.label16.Text = "Spare Parts";
            // 
            // PartsDGV
            // 
            this.PartsDGV.AllowUserToAddRows = false;
            this.PartsDGV.AllowUserToDeleteRows = false;
            this.PartsDGV.AllowUserToResizeColumns = false;
            this.PartsDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            this.PartsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.PartsDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsDGV.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PartsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.PartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Magneto", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PartsDGV.DefaultCellStyle = dataGridViewCellStyle28;
            this.PartsDGV.Location = new System.Drawing.Point(17, 120);
            this.PartsDGV.Name = "PartsDGV";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Magneto", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PartsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            this.PartsDGV.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.PartsDGV.RowTemplate.Height = 24;
            this.PartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDGV.Size = new System.Drawing.Size(366, 397);
            this.PartsDGV.TabIndex = 21;
            this.PartsDGV.VirtualMode = true;
            this.PartsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDGV_CellContentClick);
            // 
            // CalculateFees
            // 
            this.CalculateFees.AutoSize = true;
            this.CalculateFees.BackColor = System.Drawing.Color.Black;
            this.CalculateFees.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateFees.ForeColor = System.Drawing.Color.DarkGreen;
            this.CalculateFees.Location = new System.Drawing.Point(410, 439);
            this.CalculateFees.Name = "CalculateFees";
            this.CalculateFees.Size = new System.Drawing.Size(217, 38);
            this.CalculateFees.TabIndex = 18;
            this.CalculateFees.Text = "Calculate Fees";
            this.CalculateFees.UseVisualStyleBackColor = false;
            this.CalculateFees.Click += new System.EventHandler(this.CalculateFees_Click);
            // 
            // AddParts
            // 
            this.AddParts.AutoSize = true;
            this.AddParts.BackColor = System.Drawing.Color.Black;
            this.AddParts.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddParts.ForeColor = System.Drawing.Color.Green;
            this.AddParts.Location = new System.Drawing.Point(91, 543);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(161, 38);
            this.AddParts.TabIndex = 16;
            this.AddParts.Text = "Add Parts";
            this.AddParts.UseVisualStyleBackColor = false;
            this.AddParts.Click += new System.EventHandler(this.AddParts_Click);
            // 
            // BillDate
            // 
            this.BillDate.CalendarFont = new System.Drawing.Font("Magneto", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDate.Font = new System.Drawing.Font("Magneto", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BillDate.Location = new System.Drawing.Point(411, 176);
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(200, 28);
            this.BillDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(405, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mechanic Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 4;
            // 
            // MechanicFee
            // 
            this.MechanicFee.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MechanicFee.Location = new System.Drawing.Point(412, 364);
            this.MechanicFee.Name = "MechanicFee";
            this.MechanicFee.Size = new System.Drawing.Size(199, 28);
            this.MechanicFee.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(206, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Billing";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Garage_Management_System.Properties.Resources.terzo;
            this.pictureBox1.Location = new System.Drawing.Point(1050, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangedPartDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CalculateFees;
        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.DateTimePicker BillDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MechanicFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.Label Analytics;
        private System.Windows.Forms.Label BillingLabel;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label VehicleLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button SaveBill;
        private System.Windows.Forms.Label TotalFee;
        private System.Windows.Forms.DataGridView ChangedPartDGV;
        private System.Windows.Forms.Label PartFee;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox VehicleNumber;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView PartsDGV;
        private System.Windows.Forms.Label TotalFeesLabel;
        private System.Windows.Forms.Label PartFeesLabel;
        private System.Windows.Forms.Label label5;
    }
}