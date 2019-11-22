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
            showCashier();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            showCashier();
        }

        private void Btn_toko_Click(object sender, EventArgs e)
        {
            showBank();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            showHistory();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            showTop();
        }

        private void showCashier()
        {
            panel3.Height = btn_kasir.Height;
            panel3.Top = btn_kasir.Top;
            adminKasirUserControl1.BringToFront();
            adminKasirUserControl1.Show();
            adminBalanceUserControl1.Hide();
        }

        private void showBank()
        {
            panel3.Height = btn_bank.Height;
            panel3.Top = btn_bank.Top;
            adminBalanceUserControl1.BringToFront();
            adminBalanceUserControl1.Show();
            adminKasirUserControl1.Hide();
        }

        private void showHistory()
        {
            panel3.Height = btnTransaction.Height;
            panel3.Top = btnTransaction.Top;
            adminTransactionUserControl1.BringToFront();
            adminTransactionUserControl1.Show();

        }

        private void showTop()
        {
            panel3.Height = btnTopUp.Height;
            panel3.Top = btnTopUp.Top;
            adminTopUpUserControl1.BringToFront();
            adminTopUpUserControl1.Show();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
        }
    }
}
