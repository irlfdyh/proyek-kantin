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
            DateTime localDate = DateTime.Now;
            var date = localDate.ToShortDateString().ToString();

            string query = "SELECT * FROM transaksi where tanggal_transaksi = '"+date+"'";
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

        public void loadDataId(string transId) {
            string query = "SELECT * FROM transaksi where id = "+transId+"";
            MySqlConnection connection = new MySqlConnection(myConnection);

            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = query;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception e)
            {
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

        private void Btn_Print_All_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Data Transaksi";
            printer.SubTitle = date.ToShortDateString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void Btn_Print_Data_Click(object sender, EventArgs e)
        {
            string id = tbTransactionId.Text;
            if (id == "")
            {
                MessageBox.Show("Pilih transaksi terlebih dahulu");
            }
            else
            {
                loadDataId(id);
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Data Transaksi";
                printer.SubTitle = "test";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = false;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView1);
            }
        }
    }
}
