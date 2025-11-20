namespace ASM1_DATABASE
{
    partial class Inventory_Management
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
            this.btnLow_Stock_Alert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExport_Report = new System.Windows.Forms.Button();
            this.txtName_Customer = new System.Windows.Forms.TextBox();
            this.Log_Inventory = new System.Windows.Forms.Label();
            this.Supplier_Inventory = new System.Windows.Forms.Label();
            this.UpdateQty_Inventory = new System.Windows.Forms.Label();
            this.Filter_Inventory = new System.Windows.Forms.Label();
            this.InventoryManagement = new System.Windows.Forms.Label();
            this.cbInvertory = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLow_Stock_Alert
            // 
            this.btnLow_Stock_Alert.Location = new System.Drawing.Point(329, 382);
            this.btnLow_Stock_Alert.Name = "btnLow_Stock_Alert";
            this.btnLow_Stock_Alert.Size = new System.Drawing.Size(117, 40);
            this.btnLow_Stock_Alert.TabIndex = 97;
            this.btnLow_Stock_Alert.Text = "Low Stock Alert";
            this.btnLow_Stock_Alert.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(471, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(265, 132);
            this.dataGridView1.TabIndex = 95;
            // 
            // btnExport_Report
            // 
            this.btnExport_Report.Location = new System.Drawing.Point(155, 382);
            this.btnExport_Report.Name = "btnExport_Report";
            this.btnExport_Report.Size = new System.Drawing.Size(109, 40);
            this.btnExport_Report.TabIndex = 91;
            this.btnExport_Report.Text = "Export Report";
            this.btnExport_Report.UseVisualStyleBackColor = true;
            // 
            // txtName_Customer
            // 
            this.txtName_Customer.Location = new System.Drawing.Point(270, 139);
            this.txtName_Customer.Name = "txtName_Customer";
            this.txtName_Customer.Size = new System.Drawing.Size(144, 22);
            this.txtName_Customer.TabIndex = 88;
            // 
            // Log_Inventory
            // 
            this.Log_Inventory.AutoSize = true;
            this.Log_Inventory.Location = new System.Drawing.Point(184, 252);
            this.Log_Inventory.Name = "Log_Inventory";
            this.Log_Inventory.Size = new System.Drawing.Size(30, 16);
            this.Log_Inventory.TabIndex = 87;
            this.Log_Inventory.Text = "Log";
            this.Log_Inventory.Click += new System.EventHandler(this.Log_Inventory_Click);
            // 
            // Supplier_Inventory
            // 
            this.Supplier_Inventory.AutoSize = true;
            this.Supplier_Inventory.Location = new System.Drawing.Point(184, 184);
            this.Supplier_Inventory.Name = "Supplier_Inventory";
            this.Supplier_Inventory.Size = new System.Drawing.Size(57, 16);
            this.Supplier_Inventory.TabIndex = 85;
            this.Supplier_Inventory.Text = "Supplier";
            // 
            // UpdateQty_Inventory
            // 
            this.UpdateQty_Inventory.AutoSize = true;
            this.UpdateQty_Inventory.Location = new System.Drawing.Point(189, 145);
            this.UpdateQty_Inventory.Name = "UpdateQty_Inventory";
            this.UpdateQty_Inventory.Size = new System.Drawing.Size(75, 16);
            this.UpdateQty_Inventory.TabIndex = 84;
            this.UpdateQty_Inventory.Text = "Update Qty";
            // 
            // Filter_Inventory
            // 
            this.Filter_Inventory.AutoSize = true;
            this.Filter_Inventory.Location = new System.Drawing.Point(189, 108);
            this.Filter_Inventory.Name = "Filter_Inventory";
            this.Filter_Inventory.Size = new System.Drawing.Size(36, 16);
            this.Filter_Inventory.TabIndex = 82;
            this.Filter_Inventory.Text = "Filter";
            // 
            // InventoryManagement
            // 
            this.InventoryManagement.AutoSize = true;
            this.InventoryManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryManagement.Location = new System.Drawing.Point(248, 39);
            this.InventoryManagement.Name = "InventoryManagement";
            this.InventoryManagement.Size = new System.Drawing.Size(291, 31);
            this.InventoryManagement.TabIndex = 75;
            this.InventoryManagement.Text = "Inventory Management";
            // 
            // cbInvertory
            // 
            this.cbInvertory.FormattingEnabled = true;
            this.cbInvertory.Items.AddRange(new object[] {
            "Household",
            "Business",
            "Government",
            "Other"});
            this.cbInvertory.Location = new System.Drawing.Point(249, 100);
            this.cbInvertory.Name = "cbInvertory";
            this.cbInvertory.Size = new System.Drawing.Size(138, 24);
            this.cbInvertory.TabIndex = 98;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Items.AddRange(new object[] {
            "Household",
            "Business",
            "Government",
            "Other"});
            this.cbSupplier.Location = new System.Drawing.Point(249, 176);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(154, 24);
            this.cbSupplier.TabIndex = 99;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(233, 243);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(197, 114);
            this.dataGridView2.TabIndex = 100;
            // 
            // Inventory_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbInvertory);
            this.Controls.Add(this.btnLow_Stock_Alert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExport_Report);
            this.Controls.Add(this.txtName_Customer);
            this.Controls.Add(this.Log_Inventory);
            this.Controls.Add(this.Supplier_Inventory);
            this.Controls.Add(this.UpdateQty_Inventory);
            this.Controls.Add(this.Filter_Inventory);
            this.Controls.Add(this.InventoryManagement);
            this.Name = "Inventory_Management";
            this.Text = "Inventory_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLow_Stock_Alert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExport_Report;
        private System.Windows.Forms.TextBox txtName_Customer;
        private System.Windows.Forms.Label Log_Inventory;
        private System.Windows.Forms.Label Supplier_Inventory;
        private System.Windows.Forms.Label UpdateQty_Inventory;
        private System.Windows.Forms.Label Filter_Inventory;
        private System.Windows.Forms.Label InventoryManagement;
        private System.Windows.Forms.ComboBox cbInvertory;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}