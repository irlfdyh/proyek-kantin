using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyek_kantin
{
    public partial class CashierCanteenOneForm : Form
    {
        /** configuration */
        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";

        MySqlConnection connection;
        MySqlCommand sqlCommand;
        MySqlDataReader reader;

        public CashierCanteenOneForm()
        {
            InitializeComponent();
        }

        /** variable for count food order data  */
        private static int labelCount = 1;

        private static int rice = 5000;
        private static int chick = 10000;
        private static int veg = 7000;
        private static int nood = 12000;

        private string customerName = null;

        private void price() {
            /** CP is Count Price */
            int riceCP = int.Parse(tbRicePrice.Text);
            int chickCP = int.Parse(tbChickPrice.Text);
            int vegCP = int.Parse(tbVegetablePrice.Text);
            int noodCP = int.Parse(tbNoodlePrice.Text);

            int countPrice = (riceCP+chickCP+vegCP+noodCP);
            tbPay.Text = countPrice.ToString();
        }

        private void getBalance() {
            string custId = tbCustomerId.Text;
            string query = "SELECT * FROM pelanggan WHERE id = " + custId + "";


            connection = new MySqlConnection(myConnection);
            connection.Open();

            try {

                sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = query;
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        string custBalance = reader["saldo"].ToString();
                        string custName = reader["nama"].ToString();
                        tbCustBalance.Text = custBalance;
                        customerName = custName;

                    }
                } else {
                    MessageBox.Show("Id tidak terdaftar");
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }

            connection.Close();
        }

        private void balanceRemain() {
            int custBalances = int.Parse(tbCustBalance.Text);
            int pay = int.Parse(tbPay.Text);

            /** this is for counting user remaining balance*/
            int custRemBal = custBalances - pay;

            if (custBalances > pay) {
                tbCustRemBalance.Text = custRemBal.ToString();
            } else if (custBalances > 0 && custRemBal < pay) {
                MessageBox.Show("Maaf Saldo Anda kurang");
            } else if (custBalances > 0) {
                tbCustRemBalance.Text = custRemBal.ToString();
            }
        }

        private void updateBalance() {
            int balRemain = int.Parse(tbCustRemBalance.Text);
            string custId = tbCustomerId.Text;

            string query = "UPDATE pelanggan SET saldo=@saldo WHERE id = "+custId+"";


            connection = new MySqlConnection(myConnection);
            connection.Open();

            try {
                sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.AddWithValue("@saldo", balRemain);
                sqlCommand.ExecuteNonQuery();
            } catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }

            connection.Close();
        }

        /** logic for button plus one and minus one */
        private void Btn_Plus_One_Click(object sender, EventArgs e)
        {

            /** 
             * this logic is for counting order and set into 
             * labelCount and textBox for rice price
             */
            int ricePrice = int.Parse(tbRicePrice.Text);
            int riceRes = ricePrice + rice;
            tbRicePrice.Text = riceRes.ToString();

            int riceCount = int.Parse(labelCountRice.Text);
            int countResRice = riceCount + labelCount;
            labelCountRice.Text = countResRice.ToString();

            price();
            balanceRemain();
        }

        private void Btn_Min_One_Click(object sender, EventArgs e)
        {
            int ricePrice = int.Parse(tbRicePrice.Text);
            int riceCount = int.Parse(labelCountRice.Text);

            if (ricePrice >= rice && riceCount >= labelCount) {

                int riceRes = ricePrice - rice;
                tbRicePrice.Text = riceRes.ToString();

                int countResRice = riceCount - labelCount;
                labelCountRice.Text = countResRice.ToString();
            }

            price();
            balanceRemain();
        }

        /** logic for button plus and minus two */
        private void Btn_Plus_Two_Click(object sender, EventArgs e)
        {
            int chickPrice = int.Parse(tbChickPrice.Text);
            int chickRes = chickPrice + chick;
            tbChickPrice.Text = chickRes.ToString();

            int chickCount = int.Parse(labelCountChick.Text);
            int countResChick = chickCount + labelCount;
            labelCountChick.Text = countResChick.ToString();

            price();
            balanceRemain();
        }

        private void Btn_Min_Two_Click(object sender, EventArgs e)
        {
            int chickPrice = int.Parse(tbChickPrice.Text);
            int chickCount = int.Parse(labelCountChick.Text);

            if (chickPrice >= chick && chickCount >= labelCount) {
                int chickRes = chickPrice - chick;
                tbChickPrice.Text = chickRes.ToString();

                int countResChick = chickCount - labelCount;
                labelCountChick.Text = countResChick.ToString();
            }

            price();
            balanceRemain();
        }

        /** this is logic for plus and minus at food three */
        private void Btn_Plus_Three_Click(object sender, EventArgs e)
        {
            int vegPrice = int.Parse(tbVegetablePrice.Text);
            int vegRes = vegPrice + veg;
            tbVegetablePrice.Text = vegRes.ToString();

            int vegCount = int.Parse(labelCountVeg.Text);
            int countResVeg = vegCount + labelCount;
            labelCountVeg.Text = countResVeg.ToString();

            price();
            balanceRemain();
        }

        private void Btn_Min_Three_Click(object sender, EventArgs e)
        {
            int vegPrice = int.Parse(tbVegetablePrice.Text);
            int vegCount = int.Parse(labelCountVeg.Text);

            if (vegPrice >= veg && vegCount >= labelCount) {
                int vegRes = vegPrice - veg;
                tbVegetablePrice.Text = vegRes.ToString();

                int countResVeg = vegCount - labelCount;
                labelCountVeg.Text = countResVeg.ToString();
            }

            price();
            balanceRemain();
        }

        /** button logic for plus and minus at four */
        private void Btn_Plus_Four_Click(object sender, EventArgs e)
        {
            int noodPrice = int.Parse(tbNoodlePrice.Text);
            int noodRes = noodPrice + nood;
            tbNoodlePrice.Text = noodRes.ToString();

            int noodCount = int.Parse(labelCountNood.Text);
            int countResNood = noodCount + labelCount;
            labelCountNood.Text = countResNood.ToString();

            price();
            balanceRemain();
        }

        private void Btn_Min_Four_Click(object sender, EventArgs e)
        {
            int noodPrice = int.Parse(tbNoodlePrice.Text);
            int noodCount = int.Parse(labelCountNood.Text);

            if (noodPrice >= chick && noodCount >= labelCount)
            {
                int noodRes = noodPrice - nood;
                tbNoodlePrice.Text = noodRes.ToString();

                int countResNood = noodCount - labelCount;
                labelCountNood.Text = countResNood.ToString();
            }

            price();
            balanceRemain();
        }

        private void Btn_Check_Balance_Click(object sender, EventArgs e)
        {
            getBalance();
            balanceRemain();
        }

        private void Btn_Pay_Click(object sender, EventArgs e)
        {
            int pay = int.Parse(tbPay.Text);

            if (pay > 0) {
                connection.Open();

                try
                {
                    sqlCommand = connection.CreateCommand();
                    sqlCommand.CommandText = "INSERT INTO transaksi(id_pelanggan, nama_kantin, nama_pelanggan, nama_kasir, total_bayar)" +
                        "VALUES (@custId, @canteenName, @custName, @cashName, @pay)";
                    sqlCommand.Parameters.AddWithValue("@custId", tbCustomerId.Text);
                    sqlCommand.Parameters.AddWithValue("@canteenName", tbCanteenName.Text);
                    sqlCommand.Parameters.AddWithValue("@custName", customerName);
                    sqlCommand.Parameters.AddWithValue("@cashName", tbCashierName.Text);
                    sqlCommand.Parameters.AddWithValue("@pay", tbPay.Text.ToString());
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                connection.Close();

                updateBalance();

                MessageBox.Show("Transaksi Berhasil");
                this.Close();
            } else {
                MessageBox.Show("Belum memesan apapun");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
