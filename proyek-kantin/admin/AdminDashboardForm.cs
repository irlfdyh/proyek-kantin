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


        private void showCashier()
        {
            panel3.Height = Btn_Cashier.Height;
            panel3.Top = Btn_Cashier.Top;
            adminKasirUserControl1.BringToFront();
            adminKasirUserControl1.Show();
            adminBalanceUserControl1.Hide();
            adminTransactionUserControl1.Hide();
            adminTopUpUserControl1.Hide();
        }

        private void showBank()
        {
            panel3.Height = Btn_Bank.Height;
            panel3.Top = Btn_Bank.Top;
            adminBalanceUserControl1.BringToFront();
            adminKasirUserControl1.Hide();
            adminBalanceUserControl1.Show();
            adminTransactionUserControl1.Hide();
            adminTopUpUserControl1.Hide();
        }

        private void showCustomer()
        {
            panel3.Height = Btn_Customer.Height;
            panel3.Top = Btn_Customer.Top;
            adminCustomerUserControl1.BringToFront();
            adminCustomerUserControl1.Show();
            adminKasirUserControl1.Hide();
            adminBalanceUserControl1.Hide();
            adminTransactionUserControl1.Hide();
            adminTopUpUserControl1.Hide();
        }

        private void showHistory()
        {
            panel3.Height = Btn_Transaction.Height;
            panel3.Top = Btn_Transaction.Top;
            adminTransactionUserControl1.BringToFront();
            adminKasirUserControl1.Hide();
            adminBalanceUserControl1.Hide();
            adminTransactionUserControl1.Show();
            adminTopUpUserControl1.Hide();

        }

        private void showTop()
        {
            panel3.Height = Btn_Top_Up.Height;
            panel3.Top = Btn_Top_Up.Top;
            adminTopUpUserControl1.BringToFront();
            adminKasirUserControl1.Hide();
            adminBalanceUserControl1.Hide();
            adminTransactionUserControl1.Hide();
            adminTopUpUserControl1.Show();
        }

        private void Btn_Cashier_Click(object sender, EventArgs e)
        {
            showCashier();
        }

        private void Btn_Bank_Click(object sender, EventArgs e)
        {
            showBank();
        }

        private void Btn_Transaction_Click(object sender, EventArgs e)
        {
            showHistory();
        }

        private void Btn_Top_Up_Click(object sender, EventArgs e)
        {
            showTop();
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            showCustomer();
        }
    }
}
