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

        /** Button for canteen 1 */
        private void Button1_Click(object sender, EventArgs e)
        {
            CashierCanteenOneForm canOne = new CashierCanteenOneForm();
            canOne.Show();

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
