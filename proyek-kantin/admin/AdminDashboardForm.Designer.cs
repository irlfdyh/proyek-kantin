namespace proyek_kantin
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Transaction = new System.Windows.Forms.Button();
            this.Btn_Top_Up = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Bank = new System.Windows.Forms.Button();
            this.Btn_Cashier = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.adminTopUpUserControl1 = new proyek_kantin.admin.AdminTopUpUserControl();
            this.adminTransactionUserControl1 = new proyek_kantin.admin.AdminTransactionUserControl();
            this.adminBalanceUserControl1 = new proyek_kantin.admin.AdminBalanceUserControl();
            this.adminKasirUserControl1 = new proyek_kantin.AdminCashierUserControl();
            this.adminCustomerUserControl1 = new proyek_kantin.AdminCustomerUserControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Btn_Transaction);
            this.panel1.Controls.Add(this.Btn_Customer);
            this.panel1.Controls.Add(this.Btn_Top_Up);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Bank);
            this.panel1.Controls.Add(this.Btn_Cashier);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 562);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Transaction
            // 
            this.Btn_Transaction.FlatAppearance.BorderSize = 0;
            this.Btn_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Transaction.Location = new System.Drawing.Point(12, 465);
            this.Btn_Transaction.Name = "Btn_Transaction";
            this.Btn_Transaction.Size = new System.Drawing.Size(235, 75);
            this.Btn_Transaction.TabIndex = 8;
            this.Btn_Transaction.Text = "Riwayat Transaksi";
            this.Btn_Transaction.UseVisualStyleBackColor = true;
            this.Btn_Transaction.Click += new System.EventHandler(this.Btn_Transaction_Click);
            // 
            // Btn_Top_Up
            // 
            this.Btn_Top_Up.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Top_Up.FlatAppearance.BorderSize = 0;
            this.Btn_Top_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Top_Up.Location = new System.Drawing.Point(12, 384);
            this.Btn_Top_Up.Name = "Btn_Top_Up";
            this.Btn_Top_Up.Size = new System.Drawing.Size(235, 75);
            this.Btn_Top_Up.TabIndex = 7;
            this.Btn_Top_Up.Text = "Riwayat TopUp";
            this.Btn_Top_Up.UseVisualStyleBackColor = true;
            this.Btn_Top_Up.Click += new System.EventHandler(this.Btn_Top_Up_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 75);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Admin";
            // 
            // Btn_Bank
            // 
            this.Btn_Bank.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Bank.FlatAppearance.BorderSize = 0;
            this.Btn_Bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Bank.Location = new System.Drawing.Point(12, 222);
            this.Btn_Bank.Name = "Btn_Bank";
            this.Btn_Bank.Size = new System.Drawing.Size(235, 75);
            this.Btn_Bank.TabIndex = 3;
            this.Btn_Bank.Text = "Petugas Bank";
            this.Btn_Bank.UseVisualStyleBackColor = true;
            this.Btn_Bank.Click += new System.EventHandler(this.Btn_Bank_Click);
            // 
            // Btn_Cashier
            // 
            this.Btn_Cashier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Cashier.FlatAppearance.BorderSize = 0;
            this.Btn_Cashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cashier.Location = new System.Drawing.Point(12, 141);
            this.Btn_Cashier.Name = "Btn_Cashier";
            this.Btn_Cashier.Size = new System.Drawing.Size(235, 75);
            this.Btn_Cashier.TabIndex = 1;
            this.Btn_Cashier.Text = "Kasir";
            this.Btn_Cashier.UseVisualStyleBackColor = true;
            this.Btn_Cashier.Click += new System.EventHandler(this.Btn_Cashier_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customer.Location = new System.Drawing.Point(12, 303);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Size = new System.Drawing.Size(235, 75);
            this.Btn_Customer.TabIndex = 7;
            this.Btn_Customer.Text = "Pelanggan";
            this.Btn_Customer.UseVisualStyleBackColor = true;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // adminTopUpUserControl1
            // 
            this.adminTopUpUserControl1.Location = new System.Drawing.Point(249, 0);
            this.adminTopUpUserControl1.Name = "adminTopUpUserControl1";
            this.adminTopUpUserControl1.Size = new System.Drawing.Size(736, 562);
            this.adminTopUpUserControl1.TabIndex = 4;
            // 
            // adminTransactionUserControl1
            // 
            this.adminTransactionUserControl1.Location = new System.Drawing.Point(249, 0);
            this.adminTransactionUserControl1.Name = "adminTransactionUserControl1";
            this.adminTransactionUserControl1.Size = new System.Drawing.Size(736, 562);
            this.adminTransactionUserControl1.TabIndex = 3;
            // 
            // adminBalanceUserControl1
            // 
            this.adminBalanceUserControl1.Location = new System.Drawing.Point(249, 0);
            this.adminBalanceUserControl1.Name = "adminBalanceUserControl1";
            this.adminBalanceUserControl1.Size = new System.Drawing.Size(736, 562);
            this.adminBalanceUserControl1.TabIndex = 2;
            // 
            // adminKasirUserControl1
            // 
            this.adminKasirUserControl1.Location = new System.Drawing.Point(249, 0);
            this.adminKasirUserControl1.Name = "adminKasirUserControl1";
            this.adminKasirUserControl1.Size = new System.Drawing.Size(736, 562);
            this.adminKasirUserControl1.TabIndex = 1;
            // 
            // adminCustomerUserControl1
            // 
            this.adminCustomerUserControl1.Location = new System.Drawing.Point(249, 0);
            this.adminCustomerUserControl1.Name = "adminCustomerUserControl1";
            this.adminCustomerUserControl1.Size = new System.Drawing.Size(736, 562);
            this.adminCustomerUserControl1.TabIndex = 5;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.adminCustomerUserControl1);
            this.Controls.Add(this.adminTopUpUserControl1);
            this.Controls.Add(this.adminTransactionUserControl1);
            this.Controls.Add(this.adminBalanceUserControl1);
            this.Controls.Add(this.adminKasirUserControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Bank;
        private System.Windows.Forms.Button Btn_Cashier;
        private System.Windows.Forms.ImageList imageList1;
        private AdminCashierUserControl adminKasirUserControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private admin.AdminBalanceUserControl adminBalanceUserControl1;
        private admin.AdminTransactionUserControl adminTransactionUserControl1;
        private admin.AdminTopUpUserControl adminTopUpUserControl1;
        private System.Windows.Forms.Button Btn_Top_Up;
        private System.Windows.Forms.Button Btn_Transaction;
        private System.Windows.Forms.Button Btn_Customer;
        private AdminCustomerUserControl adminCustomerUserControl1;
    }
}

