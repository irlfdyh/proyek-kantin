namespace proyek_kantin.balance
{
    partial class BalanceAdministratorForm
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
            this.tbUserNum = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.tbAccountanName = new System.Windows.Forms.TextBox();
            this.Btn_Print_Data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbUserNum
            // 
            this.tbUserNum.Location = new System.Drawing.Point(141, 37);
            this.tbUserNum.Name = "tbUserNum";
            this.tbUserNum.Size = new System.Drawing.Size(118, 20);
            this.tbUserNum.TabIndex = 1;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(141, 75);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(118, 20);
            this.tbBalance.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Nomor Induk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nominal TopUp";
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Confirm.FlatAppearance.BorderSize = 0;
            this.Btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.Btn_Confirm.Location = new System.Drawing.Point(265, 73);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 4;
            this.Btn_Confirm.Text = "Konfirmasi";
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // tbAccountanName
            // 
            this.tbAccountanName.Location = new System.Drawing.Point(12, 127);
            this.tbAccountanName.Name = "tbAccountanName";
            this.tbAccountanName.Size = new System.Drawing.Size(118, 20);
            this.tbAccountanName.TabIndex = 1;
            this.tbAccountanName.Visible = false;
            // 
            // Btn_Print_Data
            // 
            this.Btn_Print_Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Print_Data.FlatAppearance.BorderSize = 0;
            this.Btn_Print_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print_Data.ForeColor = System.Drawing.Color.White;
            this.Btn_Print_Data.Location = new System.Drawing.Point(460, 124);
            this.Btn_Print_Data.Name = "Btn_Print_Data";
            this.Btn_Print_Data.Size = new System.Drawing.Size(75, 23);
            this.Btn_Print_Data.TabIndex = 4;
            this.Btn_Print_Data.Text = "Cetak Data";
            this.Btn_Print_Data.UseVisualStyleBackColor = false;
            this.Btn_Print_Data.Click += new System.EventHandler(this.Btn_Print_Data_Click);
            // 
            // BalanceAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 508);
            this.Controls.Add(this.Btn_Print_Data);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAccountanName);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.tbUserNum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BalanceAdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanceAdministratorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbUserNum;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Confirm;
        public System.Windows.Forms.TextBox tbAccountanName;
        private System.Windows.Forms.Button Btn_Print_Data;
    }
}