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
    public partial class FoodTransaction : UserControl
    {
        public FoodTransaction()
        {
            InitializeComponent();
        }

        /** Button for canteen 1 */
        private void Button1_Click(object sender, EventArgs e)
        {
            FoodCanteen1Form canOne = new FoodCanteen1Form();
            canOne.Show();

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }

        /** Button for canteen 2 */
        private void Button2_Click(object sender, EventArgs e)
        {
            FoodCanteen2Form canTwo = new FoodCanteen2Form();
            canTwo.Show();

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }

        /** Button for canteen 3 */
        private void Button3_Click(object sender, EventArgs e)
        {
            FoodCanteen3Form canThree = new FoodCanteen3Form();
            canThree.Show();

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }

        /** Button for canteen 4 */
        private void Button4_Click(object sender, EventArgs e)
        {
            FoodCanteen4Form canFour = new FoodCanteen4Form();
            canFour.Show();

            CashierDashboardForm form = new CashierDashboardForm();
            form.Dispose();
        }
    }
}
