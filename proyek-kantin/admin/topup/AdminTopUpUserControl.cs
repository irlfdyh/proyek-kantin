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

namespace proyek_kantin.admin
{
    public partial class AdminTopUpUserControl : UserControl
    {
        MySqlCommand command;
        public AdminTopUpUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";

        private void LoadData()
        {
            DateTime localDate = DateTime.Now;
            var date = dateTimePicker1.Value.ToShortDateString();

            string query = "SELECT * FROM topup WHERE tanggal_topup = '" + localDate.ToShortDateString() + "'";
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

        private void SpecData()
        {
            var date = dateTimePicker1.Value.ToShortDateString();

            string query = "SELECT * FROM topup WHERE tanggal_topup = '" + date + "'";
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

        private void Btn_All_Data_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM topup";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            SpecData();
        }
    }
}
