namespace proyek_kantin.cashier
{
    partial class TransactionHistoryUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Print_All = new System.Windows.Forms.Button();
            this.Btn_Print_Data = new System.Windows.Forms.Button();
            this.tbTransactionId = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Refresh_Data = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTransactionId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 90);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Riwayat Tansaksi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 388);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // Btn_Print_All
            // 
            this.Btn_Print_All.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Print_All.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Print_All.FlatAppearance.BorderSize = 0;
            this.Btn_Print_All.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Print_All.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Print_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print_All.ForeColor = System.Drawing.Color.White;
            this.Btn_Print_All.Location = new System.Drawing.Point(18, 109);
            this.Btn_Print_All.Name = "Btn_Print_All";
            this.Btn_Print_All.Size = new System.Drawing.Size(135, 30);
            this.Btn_Print_All.TabIndex = 5;
            this.Btn_Print_All.Text = "Cetak Semua Data";
            this.Btn_Print_All.UseVisualStyleBackColor = false;
            // 
            // Btn_Print_Data
            // 
            this.Btn_Print_Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Print_Data.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Print_Data.FlatAppearance.BorderSize = 0;
            this.Btn_Print_Data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Print_Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Print_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print_Data.ForeColor = System.Drawing.Color.White;
            this.Btn_Print_Data.Location = new System.Drawing.Point(159, 109);
            this.Btn_Print_Data.Name = "Btn_Print_Data";
            this.Btn_Print_Data.Size = new System.Drawing.Size(143, 30);
            this.Btn_Print_Data.TabIndex = 5;
            this.Btn_Print_Data.Text = "Cetak Data Transaksi";
            this.Btn_Print_Data.UseVisualStyleBackColor = false;
            // 
            // tbTransactionId
            // 
            this.tbTransactionId.Location = new System.Drawing.Point(316, 43);
            this.tbTransactionId.Name = "tbTransactionId";
            this.tbTransactionId.Size = new System.Drawing.Size(100, 20);
            this.tbTransactionId.TabIndex = 6;
            this.tbTransactionId.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 30);
            this.textBox2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(687, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Btn_Refresh_Data
            // 
            this.Btn_Refresh_Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Refresh_Data.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Refresh_Data.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh_Data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Refresh_Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Refresh_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh_Data.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh_Data.Location = new System.Drawing.Point(424, 109);
            this.Btn_Refresh_Data.Name = "Btn_Refresh_Data";
            this.Btn_Refresh_Data.Size = new System.Drawing.Size(30, 30);
            this.Btn_Refresh_Data.TabIndex = 5;
            this.Btn_Refresh_Data.Text = "R";
            this.Btn_Refresh_Data.UseVisualStyleBackColor = false;
            this.Btn_Refresh_Data.Click += new System.EventHandler(this.Btn_Refresh_Data_Click);
            // 
            // TransactionHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Refresh_Data);
            this.Controls.Add(this.Btn_Print_Data);
            this.Controls.Add(this.Btn_Print_All);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionHistoryUserControl";
            this.Size = new System.Drawing.Size(736, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Print_All;
        private System.Windows.Forms.Button Btn_Print_Data;
        private System.Windows.Forms.TextBox tbTransactionId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Refresh_Data;
    }
}
