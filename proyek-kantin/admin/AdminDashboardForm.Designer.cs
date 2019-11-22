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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bank = new System.Windows.Forms.Button();
            this.btn_kasir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminTopUpUserControl1 = new proyek_kantin.admin.AdminTopUpUserControl();
            this.adminTransactionUserControl1 = new proyek_kantin.admin.AdminTransactionUserControl();
            this.adminBalanceUserControl1 = new proyek_kantin.admin.AdminBalanceUserControl();
            this.adminKasirUserControl1 = new proyek_kantin.AdminCashierUserControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnTopUp);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_bank);
            this.panel1.Controls.Add(this.btn_kasir);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 562);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 141);
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
            // btn_bank
            // 
            this.btn_bank.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_bank.FlatAppearance.BorderSize = 0;
            this.btn_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bank.Location = new System.Drawing.Point(0, 222);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(247, 75);
            this.btn_bank.TabIndex = 3;
            this.btn_bank.Text = "Petugas Bank";
            this.btn_bank.UseVisualStyleBackColor = true;
            this.btn_bank.Click += new System.EventHandler(this.Btn_toko_Click);
            // 
            // btn_kasir
            // 
            this.btn_kasir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kasir.FlatAppearance.BorderSize = 0;
            this.btn_kasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kasir.Location = new System.Drawing.Point(0, 141);
            this.btn_kasir.Name = "btn_kasir";
            this.btn_kasir.Size = new System.Drawing.Size(247, 75);
            this.btn_kasir.TabIndex = 1;
            this.btn_kasir.Text = "Kasir";
            this.btn_kasir.UseVisualStyleBackColor = true;
            this.btn_kasir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Location = new System.Drawing.Point(0, 303);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(247, 75);
            this.btnTransaction.TabIndex = 6;
            this.btnTransaction.Text = "Riwayat Transaksi";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnTopUp
            // 
            this.btnTopUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTopUp.FlatAppearance.BorderSize = 0;
            this.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopUp.Location = new System.Drawing.Point(0, 384);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(247, 75);
            this.btnTopUp.TabIndex = 7;
            this.btnTopUp.Text = "Riwayat TopUp";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
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
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
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
        private System.Windows.Forms.Button btn_bank;
        private System.Windows.Forms.Button btn_kasir;
        private System.Windows.Forms.ImageList imageList1;
        private AdminCashierUserControl adminKasirUserControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private admin.AdminBalanceUserControl adminBalanceUserControl1;
        private admin.AdminTransactionUserControl adminTransactionUserControl1;
        private admin.AdminTopUpUserControl adminTopUpUserControl1;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Button button1;
    }
}

