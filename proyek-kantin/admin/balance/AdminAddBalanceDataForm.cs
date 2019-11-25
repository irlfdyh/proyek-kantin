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

namespace proyek_kantin.admin
{
    public partial class AdminAddBalanceDataForm : Form
    {
        public AdminAddBalanceDataForm()
        {
            InitializeComponent();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";

        private void AddData()
        {
            Random random = new Random();
            int randNum;

            randNum = random.Next(10000000);


            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand command;

            connection.Open();

            try
            {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO petugas(nip, username, password, nama, alamat, no_hp, kelas) " +
                    "VALUES (@nip, @username, @password, @name, @address, @phone, @class)";
                command.Parameters.AddWithValue("@nip", randNum.ToString());
                command.Parameters.AddWithValue("@username", tbUsername.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@address", tbAddress.Text);
                command.Parameters.AddWithValue("@phone", tbPhone.Text);
                command.Parameters.AddWithValue("@class", 2);
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

            string query = "UPDATE petugas SET username=@username, password=@password, nama=@name, alamat=@address, " +
                "no_hp=@phone WHERE id = " + userId + "";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand command;

            connection.Open();

            try
            {
                command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@username", tbUsername.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@address", tbAddress.Text);
                command.Parameters.AddWithValue("@phone", tbPhone.Text);
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
