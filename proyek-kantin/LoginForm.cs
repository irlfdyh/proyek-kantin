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
    public partial class LoginForm : Form
    {

        MySqlConnection connection;
        MySqlCommand sqlCommand;
        MySqlDataReader reader;

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';" ;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            LoginLogic();
        }

        private void LoginLogic() {

            /** get username and password from text box */
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string query = "SELECT * FROM petugas WHERE username = '" + username + "' AND password = '" + password + "'";

            connection = new MySqlConnection(myConnection);
            connection.Open();

            if (username != "" && password != "") {
                try {
                    sqlCommand = connection.CreateCommand();
                    sqlCommand.CommandText = query;
                    reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows) {
                        while (reader.Read()) {
                            string userClass = reader["kelas"].ToString();
                            if (userClass == "1") {
                                MessageBox.Show("Login Sebagai kasir");

                                CashierDashboardForm cashier = new CashierDashboardForm();
                                cashier.Show();
                                this.Hide();
                            } else if (userClass == "2") {
                                MessageBox.Show("Login Topup");
                            }
                        }
                    } else if (username == "admin" && password == "admin") {
                        MessageBox.Show("welcome admin");

                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                        this.Hide();
                    }
                    connection.Close();
                } catch (Exception e) {
                    MessageBox.Show(e.Message.ToString());
                }
            } else if (username == "") {
                MessageBox.Show("username tidak boleh kosong!!");
            } else if (password == "") {
                MessageBox.Show("password tidak boleh kosong!!");
            }
        }

    }
}
