namespace proyek_kantin.admin
{
    partial class AdminTopUpUserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Print_Data = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_All_Data = new System.Windows.Forms.Button();
            this.Btn_Fresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Btn_Fresh);
            this.panel2.Controls.Add(this.Btn_All_Data);
            this.panel2.Controls.Add(this.Btn_Print_Data);
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 473);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 395);
            this.dataGridView1.TabIndex = 3;
            // 
            // Btn_Print_Data
            // 
            this.Btn_Print_Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Print_Data.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Print_Data.FlatAppearance.BorderSize = 0;
            this.Btn_Print_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print_Data.ForeColor = System.Drawing.Color.White;
            this.Btn_Print_Data.Location = new System.Drawing.Point(14, 11);
            this.Btn_Print_Data.Name = "Btn_Print_Data";
            this.Btn_Print_Data.Size = new System.Drawing.Size(111, 30);
            this.Btn_Print_Data.TabIndex = 0;
            this.Btn_Print_Data.Text = "Cetak Data";
            this.Btn_Print_Data.UseVisualStyleBackColor = false;
            this.Btn_Print_Data.Click += new System.EventHandler(this.Btn_Print_Data_Click);
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
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Top Up";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(523, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Btn_All_Data
            // 
            this.Btn_All_Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_All_Data.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_All_Data.FlatAppearance.BorderSize = 0;
            this.Btn_All_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_All_Data.ForeColor = System.Drawing.Color.White;
            this.Btn_All_Data.Location = new System.Drawing.Point(131, 11);
            this.Btn_All_Data.Name = "Btn_All_Data";
            this.Btn_All_Data.Size = new System.Drawing.Size(111, 30);
            this.Btn_All_Data.TabIndex = 0;
            this.Btn_All_Data.Text = "Lihat Semua Data";
            this.Btn_All_Data.UseVisualStyleBackColor = false;
            this.Btn_All_Data.Click += new System.EventHandler(this.Btn_All_Data_Click);
            // 
            // Btn_Fresh
            // 
            this.Btn_Fresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Fresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Fresh.FlatAppearance.BorderSize = 0;
            this.Btn_Fresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Fresh.Location = new System.Drawing.Point(489, 18);
            this.Btn_Fresh.Name = "Btn_Fresh";
            this.Btn_Fresh.Size = new System.Drawing.Size(28, 30);
            this.Btn_Fresh.TabIndex = 0;
            this.Btn_Fresh.Text = "R";
            this.Btn_Fresh.UseVisualStyleBackColor = false;
            this.Btn_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // AdminTopUpUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminTopUpUserControl";
            this.Size = new System.Drawing.Size(736, 562);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Print_Data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Btn_All_Data;
        private System.Windows.Forms.Button Btn_Fresh;
    }
}
