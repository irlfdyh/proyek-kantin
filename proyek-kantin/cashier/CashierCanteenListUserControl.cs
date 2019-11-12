using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyek_kantin
{
    public partial class CashierCanteenListUserControl : UserControl
    {
        public CashierCanteenListUserControl()
        {
            InitializeComponent();
        }

        protected string getName() {
            CashierDashboardForm cashierDashboard = new CashierDashboardForm();
            string cashierName = cashierDashboard.tbCashierName.Text;
            return cashierName;
        }

        /** Button for canteen 1 */
        private void Button1_Click(object sender, EventArgs e)
        {
            CashierDashboardForm cashierDashboard = new CashierDashboardForm();
            string cashierName = cashierDashboard.tbCashierName.Text;

            CashierCanteenOneForm canOne = new CashierCanteenOneForm();
            canOne.Show();
            canOne.tbCashierName.Text = cashierName;

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }

        /** Button for canteen 2 */
        private void Button2_Click(object sender, EventArgs e)
        {
            CashierCanteenTwoForm canTwo = new CashierCanteenTwoForm();
            canTwo.Show();

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }

        /** Button for canteen 3 */
        private void Button3_Click(object sender, EventArgs e)
        {
            CashierCanteenThreeForm canThree = new CashierCanteenThreeForm();
            canThree.Show();

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }

        /** Button for canteen 4 */
        private void Button4_Click(object sender, EventArgs e)
        {
            CashierCanteenFourForm canFour = new CashierCanteenFourForm();
            canFour.Show();

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }
    }
}
