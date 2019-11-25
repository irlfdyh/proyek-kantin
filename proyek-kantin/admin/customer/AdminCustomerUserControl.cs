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
using proyek_kantin.admin.customer;

namespace proyek_kantin
{
    public partial class AdminCustomerUserControl : UserControl
    {
        MySqlCommand command;
        public AdminCustomerUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";
        string userId = null;
        string name = null;
        string userClass = null;

        private void LoadData()
        {
            string query = "SELECT * FROM pelanggan";
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
                sqlCommand.CommandText = "DELETE FROM pelanggan WHERE id = '" + userId + "'";
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
            name = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            userClass = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AdminAddCustomerForm add = new AdminAddCustomerForm();
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
                AdminAddCustomerForm dataForm = new AdminAddCustomerForm();

                dataForm.Show();
                dataForm.tbId.Text = id;
                dataForm.tbName.Text = name;
                dataForm.tbClass.Text = userClass;

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
