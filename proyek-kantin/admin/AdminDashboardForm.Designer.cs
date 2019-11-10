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
            this.btn_toko = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kasir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.adminKasirUserControl1 = new proyek_kantin.AdminCashierUserControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_toko);
            this.panel1.Controls.Add(this.panel2);
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
            this.label1.Location = new System.Drawing.Point(96, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Admin";
            // 
            // btn_toko
            // 
            this.btn_toko.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_toko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toko.Location = new System.Drawing.Point(0, 222);
            this.btn_toko.Name = "btn_toko";
            this.btn_toko.Size = new System.Drawing.Size(247, 75);
            this.btn_toko.TabIndex = 3;
            this.btn_toko.Text = "Toko";
            this.btn_toko.UseVisualStyleBackColor = true;
            this.btn_toko.Click += new System.EventHandler(this.Btn_toko_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 54);
            this.panel2.TabIndex = 2;
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
        private System.Windows.Forms.Button btn_toko;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_kasir;
        private System.Windows.Forms.ImageList imageList1;
        private AdminCashierUserControl adminKasirUserControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

