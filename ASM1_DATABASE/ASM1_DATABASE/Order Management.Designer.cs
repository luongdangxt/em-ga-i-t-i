namespace ASM1_DATABASE
{
    partial class Order_Management
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave_Employee = new System.Windows.Forms.Button();
            this.btnPrintInvoice_Order = new System.Windows.Forms.Button();
            this.Items_Order = new System.Windows.Forms.Label();
            this.cbCustomer_Order = new System.Windows.Forms.ComboBox();
            this.txtTotal_Order = new System.Windows.Forms.TextBox();
            this.txtName_Employee = new System.Windows.Forms.TextBox();
            this.Password_Employee = new System.Windows.Forms.Label();
            this.Payment_Order = new System.Windows.Forms.Label();
            this.Employee_Order = new System.Windows.Forms.Label();
            this.Customer_Order = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.Search_Employee = new System.Windows.Forms.Label();
            this.OrderManagement = new System.Windows.Forms.Label();
            this.cbEmployee_Order = new System.Windows.Forms.ComboBox();
            this.cbPayment_Order = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(265, 181);
            this.dataGridView1.TabIndex = 72;
            // 
            // btnSave_Employee
            // 
            this.btnSave_Employee.Location = new System.Drawing.Point(200, 377);
            this.btnSave_Employee.Name = "btnSave_Employee";
            this.btnSave_Employee.Size = new System.Drawing.Size(80, 40);
            this.btnSave_Employee.TabIndex = 71;
            this.btnSave_Employee.Text = "Save";
            this.btnSave_Employee.UseVisualStyleBackColor = true;
            this.btnSave_Employee.Click += new System.EventHandler(this.btnSave_Employee_Click);
            // 
            // btnPrintInvoice_Order
            // 
            this.btnPrintInvoice_Order.Location = new System.Drawing.Point(324, 377);
            this.btnPrintInvoice_Order.Name = "btnPrintInvoice_Order";
            this.btnPrintInvoice_Order.Size = new System.Drawing.Size(97, 40);
            this.btnPrintInvoice_Order.TabIndex = 70;
            this.btnPrintInvoice_Order.Text = "Print Invoice";
            this.btnPrintInvoice_Order.UseVisualStyleBackColor = true;
            // 
            // Items_Order
            // 
            this.Items_Order.AutoSize = true;
            this.Items_Order.Location = new System.Drawing.Point(501, 100);
            this.Items_Order.Name = "Items_Order";
            this.Items_Order.Size = new System.Drawing.Size(39, 16);
            this.Items_Order.TabIndex = 66;
            this.Items_Order.Text = "Items";
            // 
            // cbCustomer_Order
            // 
            this.cbCustomer_Order.FormattingEnabled = true;
            this.cbCustomer_Order.Items.AddRange(new object[] {
            "Household",
            "Business",
            "Government",
            "Other"});
            this.cbCustomer_Order.Location = new System.Drawing.Point(267, 171);
            this.cbCustomer_Order.Name = "cbCustomer_Order";
            this.cbCustomer_Order.Size = new System.Drawing.Size(131, 24);
            this.cbCustomer_Order.TabIndex = 65;
            // 
            // txtTotal_Order
            // 
            this.txtTotal_Order.Location = new System.Drawing.Point(250, 285);
            this.txtTotal_Order.Name = "txtTotal_Order";
            this.txtTotal_Order.Size = new System.Drawing.Size(148, 22);
            this.txtTotal_Order.TabIndex = 62;
            // 
            // txtName_Employee
            // 
            this.txtName_Employee.Location = new System.Drawing.Point(281, 137);
            this.txtName_Employee.Name = "txtName_Employee";
            this.txtName_Employee.Size = new System.Drawing.Size(183, 22);
            this.txtName_Employee.TabIndex = 61;
            // 
            // Password_Employee
            // 
            this.Password_Employee.AutoSize = true;
            this.Password_Employee.Location = new System.Drawing.Point(197, 288);
            this.Password_Employee.Name = "Password_Employee";
            this.Password_Employee.Size = new System.Drawing.Size(38, 16);
            this.Password_Employee.TabIndex = 60;
            this.Password_Employee.Text = "Total";
            // 
            // Payment_Order
            // 
            this.Payment_Order.AutoSize = true;
            this.Payment_Order.Location = new System.Drawing.Point(197, 247);
            this.Payment_Order.Name = "Payment_Order";
            this.Payment_Order.Size = new System.Drawing.Size(60, 16);
            this.Payment_Order.TabIndex = 59;
            this.Payment_Order.Text = "Payment";
            // 
            // Employee_Order
            // 
            this.Employee_Order.AutoSize = true;
            this.Employee_Order.Location = new System.Drawing.Point(197, 214);
            this.Employee_Order.Name = "Employee_Order";
            this.Employee_Order.Size = new System.Drawing.Size(69, 16);
            this.Employee_Order.TabIndex = 58;
            this.Employee_Order.Text = "Employee";
            // 
            // Customer_Order
            // 
            this.Customer_Order.AutoSize = true;
            this.Customer_Order.Location = new System.Drawing.Point(197, 179);
            this.Customer_Order.Name = "Customer_Order";
            this.Customer_Order.Size = new System.Drawing.Size(64, 16);
            this.Customer_Order.TabIndex = 57;
            this.Customer_Order.Text = "Customer";
            this.Customer_Order.Click += new System.EventHandler(this.Position_Click);
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Location = new System.Drawing.Point(202, 140);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(73, 16);
            this.OrderDate.TabIndex = 56;
            this.OrderDate.Text = "Order Date";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(258, 100);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(195, 22);
            this.txtSearchEmployee.TabIndex = 55;
            // 
            // Search_Employee
            // 
            this.Search_Employee.AutoSize = true;
            this.Search_Employee.Location = new System.Drawing.Point(202, 103);
            this.Search_Employee.Name = "Search_Employee";
            this.Search_Employee.Size = new System.Drawing.Size(50, 16);
            this.Search_Employee.TabIndex = 54;
            this.Search_Employee.Text = "Search";
            // 
            // OrderManagement
            // 
            this.OrderManagement.AutoSize = true;
            this.OrderManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderManagement.Location = new System.Drawing.Point(261, 34);
            this.OrderManagement.Name = "OrderManagement";
            this.OrderManagement.Size = new System.Drawing.Size(247, 31);
            this.OrderManagement.TabIndex = 47;
            this.OrderManagement.Text = "Order Management";
            // 
            // cbEmployee_Order
            // 
            this.cbEmployee_Order.FormattingEnabled = true;
            this.cbEmployee_Order.Items.AddRange(new object[] {
            "Household",
            "Business",
            "Government",
            "Other"});
            this.cbEmployee_Order.Location = new System.Drawing.Point(272, 211);
            this.cbEmployee_Order.Name = "cbEmployee_Order";
            this.cbEmployee_Order.Size = new System.Drawing.Size(131, 24);
            this.cbEmployee_Order.TabIndex = 73;
            // 
            // cbPayment_Order
            // 
            this.cbPayment_Order.FormattingEnabled = true;
            this.cbPayment_Order.Items.AddRange(new object[] {
            "Household",
            "Business",
            "Government",
            "Other"});
            this.cbPayment_Order.Location = new System.Drawing.Point(290, 247);
            this.cbPayment_Order.Name = "cbPayment_Order";
            this.cbPayment_Order.Size = new System.Drawing.Size(131, 24);
            this.cbPayment_Order.TabIndex = 74;
            // 
            // Order_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPayment_Order);
            this.Controls.Add(this.cbEmployee_Order);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave_Employee);
            this.Controls.Add(this.btnPrintInvoice_Order);
            this.Controls.Add(this.Items_Order);
            this.Controls.Add(this.cbCustomer_Order);
            this.Controls.Add(this.txtTotal_Order);
            this.Controls.Add(this.txtName_Employee);
            this.Controls.Add(this.Password_Employee);
            this.Controls.Add(this.Payment_Order);
            this.Controls.Add(this.Employee_Order);
            this.Controls.Add(this.Customer_Order);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.Search_Employee);
            this.Controls.Add(this.OrderManagement);
            this.Name = "Order_Management";
            this.Text = "Order_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave_Employee;
        private System.Windows.Forms.Button btnPrintInvoice_Order;
        private System.Windows.Forms.Label Items_Order;
        private System.Windows.Forms.ComboBox cbCustomer_Order;
        private System.Windows.Forms.TextBox txtTotal_Order;
        private System.Windows.Forms.TextBox txtName_Employee;
        private System.Windows.Forms.Label Password_Employee;
        private System.Windows.Forms.Label Payment_Order;
        private System.Windows.Forms.Label Employee_Order;
        private System.Windows.Forms.Label Customer_Order;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label Search_Employee;
        private System.Windows.Forms.Label OrderManagement;
        private System.Windows.Forms.ComboBox cbEmployee_Order;
        private System.Windows.Forms.ComboBox cbPayment_Order;
    }
}