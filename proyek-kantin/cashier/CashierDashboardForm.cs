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
    public partial class CashierDashboardForm : Form
    {
        public CashierDashboardForm()
        {
            InitializeComponent();
            panel3.Height = btnTransaction.Height;
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            panel3.Height = btnTransaction.Height;
            panel3.Top = btnTransaction.Top;
            foodTransaction1.Hide();
        }

        private void BtnCanteen_Click(object sender, EventArgs e)
        {
            panel3.Height = btnCanteen.Height;
            panel3.Top = btnCanteen.Top;
            foodTransaction1.BringToFront();
            foodTransaction1.Show();
        }

    }
}
