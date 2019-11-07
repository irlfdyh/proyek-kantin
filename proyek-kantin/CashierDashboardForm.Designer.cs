namespace proyek_kantin
{
    partial class CashierDashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCanteen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.foodTransaction1 = new proyek_kantin.FoodTransaction();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCanteen);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 562);
            this.panel1.TabIndex = 2;
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
            // btnCanteen
            // 
            this.btnCanteen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCanteen.FlatAppearance.BorderSize = 0;
            this.btnCanteen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanteen.Location = new System.Drawing.Point(0, 222);
            this.btnCanteen.Name = "btnCanteen";
            this.btnCanteen.Size = new System.Drawing.Size(247, 75);
            this.btnCanteen.TabIndex = 3;
            this.btnCanteen.Text = "Daftar Kantin";
            this.btnCanteen.UseVisualStyleBackColor = true;
            this.btnCanteen.Click += new System.EventHandler(this.BtnCanteen_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 54);
            this.panel2.TabIndex = 2;
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Location = new System.Drawing.Point(0, 141);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(247, 75);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Transaksi";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // foodTransaction1
            // 
            this.foodTransaction1.Location = new System.Drawing.Point(253, 0);
            this.foodTransaction1.Name = "foodTransaction1";
            this.foodTransaction1.Size = new System.Drawing.Size(736, 562);
            this.foodTransaction1.TabIndex = 3;
            // 
            // CashierDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.foodTransaction1);
            this.Controls.Add(this.panel1);
            this.Name = "CashierDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCanteen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTransaction;
        private FoodTransaction foodTransaction1;
    }
}