using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyek_kantin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            panel3.Height = btn_kasir.Height;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_kasir.Height;
            panel3.Top = btn_kasir.Top;
            adminKasirUserControl1.BringToFront();
            adminKasirUserControl1.Show();
        }

        private void Btn_toko_Click(object sender, EventArgs e)
        {
            panel3.Height = btn_toko.Height;
            panel3.Top = btn_toko.Top;
            adminKasirUserControl1.Hide();
        }
    }
}
