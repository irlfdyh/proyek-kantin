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
    public partial class AdminAddCashierDataForm : Form
    {
        public AdminAddCashierDataForm()
        {
            InitializeComponent();
            label7.Visible = true;
        }

        public string getId = null;
        

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";

        private void addData()
        {
            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand command;

            connection.Open();

            try {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO petugas(username, password, nama, alamat, no_hp, kelas) " +
                    "VALUES (@username, @password, @name, @address, @phone, @class)";
                command.Parameters.AddWithValue("@username", tbUsername.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);
                command.Parameters.AddWithValue("@name", tbName.Text);
                command.Parameters.AddWithValue("@address", tbAddress.Text);
                command.Parameters.AddWithValue("@phone", tbPhone.Text.ToString());
                command.Parameters.AddWithValue("@class", 1);
                command.ExecuteNonQuery();
            } catch (Exception e) {
                MessageBox.Show("error when insert data, '"+ e.Message.ToString() +"'");
            }

            connection.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            addData();
            this.Close();
        }

        private void State() {
            if (label7.Text == "null") {
                label1.Text = "Tambah Data";
            } else {
                label1.Text = "Ubah Data";
            }
        }

    }
}
