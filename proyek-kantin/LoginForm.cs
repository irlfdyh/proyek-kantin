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
using proyek_kantin.balance;

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

            try {

                sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = query;
                reader = sqlCommand.ExecuteReader();

                /** check are text box is null or filled */
                if (username != "" && password != "") {

                    if (reader.HasRows) {
                        while (reader.Read()) {
                            /** 
                             * get data response and take 'kelas' and 'nama' response 
                             * 
                             * on the database where 'kelas' = 1 is cashier
                             * and 'kelas' = 2 is balance administrator
                             */
                            string userClass = reader["kelas"].ToString();
                            string userName = reader["nama"].ToString();

                            if (userClass == "1") {
                                /** 
                                 * what is different between for example 
                                 * cashier.Show() and cashier.ShowDialog() if using cashier.Show() 
                                 * when using this.Close() the application will closed, and if using 
                                 * cashier.ShowDialog() this form will close and will focus to another
                                 * form will be open, for example  we will open AdminForm the application 
                                 * will focus to AdminForm
                                 */
                                MessageBox.Show("Selamat datang "+userName+"");

                                CashierDashboardForm cashier = new CashierDashboardForm();
                                cashier.labelCashierName.Text = "Selamat Datang " + userName + "";
                                cashier.foodTransaction1.tbCashierNameUC.Text = userName;
                                cashier.ShowDialog();
                                this.Close();

                            } else if (userClass == "2") {
                                MessageBox.Show("Selamat datang '" + userName + "'");

                                BalanceAdministratorForm balance = new BalanceAdministratorForm();
                                balance.tbAccountanName.Text = userName;
                                balance.ShowDialog();
                                this.Close();
                            }
                        }
                    } else if (username == "admin" && password == "admin") {
                        MessageBox.Show("welcome admin");

                        AdminDashboard admin = new AdminDashboard();
                        admin.ShowDialog();
                        this.Close();
                    } else {
                        MessageBox.Show("username atau password salah!!");
                    }

                } else if (username == "") {
                    MessageBox.Show("username tidak boleh kosong!!");
                } else if (password == ""){
                    MessageBox.Show("password tidak boleh kosong!!");
                }

                connection.Close();

            } catch (Exception e) {
                    MessageBox.Show(e.Message.ToString());
                }
        
        }

    }
}
