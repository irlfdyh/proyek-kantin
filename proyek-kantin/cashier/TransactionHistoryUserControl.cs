using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyek_kantin.cashier
{
    public partial class TransactionHistoryUserControl : UserControl
    {
        MySqlCommand command;
        public TransactionHistoryUserControl()
        {
            InitializeComponent();
            loadData();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";

        public void loadData() {
            string query = "SELECT * FROM transaksi";
            MySqlConnection connection = new MySqlConnection(myConnection);

            try {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = query;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            } catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbTransactionId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Btn_Refresh_Data_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
