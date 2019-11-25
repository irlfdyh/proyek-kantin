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
    public partial class AdminBalanceUserControl : UserControl
    {
        MySqlCommand command;
        public AdminBalanceUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";
        string userId = null;
        string username = null;
        string password = null;
        string name = null;
        string address = null;
        string phone = null;

        private void LoadData()
        {
            string query = "SELECT * FROM petugas WHERE kelas = 2";
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

        private void DeleteData()
        {
            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();
            try
            {
                MySqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM petugas WHERE id = '" + userId + "'";
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userId = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            username = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            password = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            name = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            address = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            phone = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AdminAddBalanceDataForm add = new AdminAddBalanceDataForm();
            add.Show();
            add.label1.Text = "Tambah Data";
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            var id = userId;
            if (id == null)
            {
                MessageBox.Show("Pilih kasir terlebih dahulu");
            }
            else
            {
                AdminAddBalanceDataForm dataForm = new AdminAddBalanceDataForm();

                dataForm.Show();
                dataForm.tbId.Text = id;
                dataForm.tbUsername.Text = username;
                dataForm.tbPassword.Text = password;
                dataForm.tbName.Text = name;
                dataForm.tbAddress.Text = address;
                dataForm.tbPhone.Text = phone;

                dataForm.label1.Text = "Ubah Data";
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }
    }
}
