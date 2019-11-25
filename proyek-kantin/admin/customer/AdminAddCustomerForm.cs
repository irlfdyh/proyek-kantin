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

namespace proyek_kantin.admin.customer
{
    public partial class AdminAddCustomerForm : Form
    {
        public AdminAddCustomerForm()
        {
            InitializeComponent();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";

        private void AddData()
        {
            Random random = new Random();
            int randNum;

            randNum = random.Next(1000000000);


            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand command;

            connection.Open();

            try
            {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO pelanggan(nis, nama, kelas, saldo) " +
                    "VALUES (@nis, @name, @class, @balance)";
                command.Parameters.AddWithValue("@nis", randNum.ToString());
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@class", tbClass.Text);
                command.Parameters.AddWithValue("@balance", 20000);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error when insert data, '" + e.Message.ToString() + "'");
            }
        }

        private void EditData(string userId)
        {

            string query = "UPDATE pelanggan SET nama=@name, kelas=@class WHERE id = " + userId + "";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand command;

            connection.Open();

            try
            {
                command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@class", tbClass.Text);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string state = label1.Text;
            string id = tbId.Text.ToString();

            if (state == "Tambah Data")
            {
                AddData();
                MessageBox.Show("Berhasil Menambahkan Data");

                this.Close();
            }
            else if (state == "Ubah Data")
            {
                EditData(id);
                MessageBox.Show("Berhasil Mengubah Data");

                this.Close();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
