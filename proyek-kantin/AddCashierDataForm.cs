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
    public partial class AddCashierDataForm : Form
    {
        public AddCashierDataForm()
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
                command.CommandText = "INSERT INTO kasir(username, password, nama, alamat, no_hp) " +
                    "VALUES (@username, @password, @nama, @alamat, @noHp)";
                command.Parameters.AddWithValue("@username", tbUsername.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);
                command.Parameters.AddWithValue("@nama", tbName.Text);
                command.Parameters.AddWithValue("@alamat", tbAddress.Text);
                command.Parameters.AddWithValue("@noHp", tbPhone.Text.ToString());
                command.ExecuteNonQuery();
            } catch (Exception e) {
                MessageBox.Show("error when insert data, '"+ e.Message.ToString() +"'");
            }

            connection.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            addData();
            this.Dispose();
        }

        private void State() {
            if (label7.Text == "null") {
                label1.Text = "Tambah Data";
            } else {
                label1.Text = "Ubah Data";
            }
        }

        private void AddCashierDataForm_Activated(object sender, EventArgs e)
        {

        }
    }
}
