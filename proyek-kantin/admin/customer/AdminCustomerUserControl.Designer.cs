namespace proyek_kantin
{
    partial class AdminCustomerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Btn_Delete);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Btn_Update);
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Controls.Add(this.Btn_Refresh);
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 473);
            this.panel2.TabIndex = 3;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(272, 11);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(80, 30);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "Hapus";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 395);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(186, 11);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(80, 30);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Ubah";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Location = new System.Drawing.Point(100, 11);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(80, 30);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Tambah";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Refresh.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh.Location = new System.Drawing.Point(14, 11);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(80, 30);
            this.Btn_Refresh.TabIndex = 0;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 90);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pelanggan kantin";
            // 
            // AdminCustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminCustomerUserControl";
            this.Size = new System.Drawing.Size(736, 562);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
