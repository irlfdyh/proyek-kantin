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

namespace proyek_kantin.balance
{
    public partial class BalanceAdministratorForm : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        public BalanceAdministratorForm()
        {
            InitializeComponent();
            LoadData();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";

        int finalBalance = 0;
        int firstBalanceCount = 0;
        string custName = null;

        private void LoadData()
        {
            DateTime localDate = DateTime.Now;

            string query = "SELECT * FROM topup WHERE tanggal_topup = '"+localDate.ToShortDateString()+"'";
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

        protected void GetBalance(string userNis)
        {
            string plusBalance = tbBalance.Text.ToString();
            string query = "SELECT * FROM pelanggan WHERE nis = "+userNis+"";

            connection = new MySqlConnection(myConnection);
            connection.Open();

            try
            {
                command = connection.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string firstBalance = reader["saldo"].ToString();
                        custName = reader["nama"].ToString();

                        firstBalanceCount = int.Parse(firstBalance);

                        if (int.Parse(plusBalance) < 5000)
                        {
                            MessageBox.Show("Minimum top up Rp.5000");
                        }
                        else
                        {
                            finalBalance = int.Parse(firstBalance) + int.Parse(plusBalance);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        protected void SetBalance(string userNis)
        {
            string query = "UPDATE pelanggan set saldo=@balance WHERE nis = "+userNis+"";

            connection = new MySqlConnection(myConnection);
            connection.Open();

            try
            {
                command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@balance", finalBalance);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void SetHistory()
        {
            string query = "INSERT INTO topup (jumlah, nama_pelanggan, nama_petugas, tanggal_topup) VALUES " +
                "(@count, @custName, @admName, @date)";

            DateTime dateTime = DateTime.Now;

            try
            {
                connection.Open();

                command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@count", finalBalance);
                command.Parameters.AddWithValue("@custName", custName);
                command.Parameters.AddWithValue("@admName", tbAccountanName.Text);
                command.Parameters.AddWithValue("@date", dateTime.ToShortDateString());
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            } 
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            string userNum = tbUserNum.Text.ToString();

            GetBalance(userNum);

            if (finalBalance < firstBalanceCount)
            {
                MessageBox.Show("Top Up Tidak Berhasil!!");
            }
            else if (finalBalance > firstBalanceCount)
            {
                SetBalance(userNum);
                MessageBox.Show("Top Up Berhasil!!");
                tbUserNum.Clear();
                tbBalance.Clear();
                SetHistory();
                LoadData();
            }
        }

        private void Btn_Print_Data_Click(object sender, EventArgs e)
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
    }
}
