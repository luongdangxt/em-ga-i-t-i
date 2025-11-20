namespace ASM1_DATABASE
{
    partial class Admin_Doashoard
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
            this.Admin_Dashboard = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.Quick = new System.Windows.Forms.Label();
            this.Recent_orders = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Full_stats = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_Dashboard
            // 
            this.Admin_Dashboard.AutoSize = true;
            this.Admin_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Dashboard.Location = new System.Drawing.Point(190, 28);
            this.Admin_Dashboard.Name = "Admin_Dashboard";
            this.Admin_Dashboard.Size = new System.Drawing.Size(343, 31);
            this.Admin_Dashboard.TabIndex = 0;
            this.Admin_Dashboard.Text = "Store X - Admin Dashboard";
            this.Admin_Dashboard.Click += new System.EventHandler(this.Admin_Dashboard_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(648, 19);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(70, 40);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // Quick
            // 
            this.Quick.AutoSize = true;
            this.Quick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quick.Location = new System.Drawing.Point(81, 91);
            this.Quick.Name = "Quick";
            this.Quick.Size = new System.Drawing.Size(113, 25);
            this.Quick.TabIndex = 8;
            this.Quick.Text = "Quick Stats";
            this.Quick.UseMnemonic = false;
            this.Quick.Click += new System.EventHandler(this.Quick_Click);
            // 
            // Recent_orders
            // 
            this.Recent_orders.AutoSize = true;
            this.Recent_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recent_orders.Location = new System.Drawing.Point(451, 91);
            this.Recent_orders.Name = "Recent_orders";
            this.Recent_orders.Size = new System.Drawing.Size(138, 25);
            this.Recent_orders.TabIndex = 9;
            this.Recent_orders.Text = "Recent Orders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(284, 217);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_Full_stats
            // 
            this.btn_Full_stats.Location = new System.Drawing.Point(639, 371);
            this.btn_Full_stats.Name = "btn_Full_stats";
            this.btn_Full_stats.Size = new System.Drawing.Size(101, 40);
            this.btn_Full_stats.TabIndex = 11;
            this.btn_Full_stats.Text = "Full Stats Btn";
            this.btn_Full_stats.UseVisualStyleBackColor = true;
            this.btn_Full_stats.Click += new System.EventHandler(this.btn_Full_stats_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(67, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(274, 222);
            this.dataGridView2.TabIndex = 12;
            // 
            // Admin_Doashoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(778, 446);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Full_stats);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Recent_orders);
            this.Controls.Add(this.Quick);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.Admin_Dashboard);
            this.Name = "Admin_Doashoard";
            this.Text = "Admin_Doashoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin_Dashboard;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label Quick;
        private System.Windows.Forms.Label Recent_orders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Full_stats;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}