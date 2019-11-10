using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace proyek_kantin
{
    public partial class AdminCashierUserControl : UserControl
    {
        public AdminCashierUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";
        public string userId = null;

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userId = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        /** this button is for move to new form */
        private void Button2_Click(object sender, EventArgs e)
        {
            AdminAddCashierDataForm add = new AdminAddCashierDataForm();
            add.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /** to update data is here */
        private void Button3_Click(object sender, EventArgs e)
        {
            AdminAddCashierDataForm dataForm = new AdminAddCashierDataForm();
            dataForm.tbUsername.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataForm.Show();
            dataForm.label7.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        /** this buttton is for deleting some data */
        private void Button4_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }

        public void LoadData() {
            MySqlConnection connection = new MySqlConnection(myConnection);
            try {
                connection.Open();
                MySqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM petugas WHERE kelas = 1";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            } catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }
            connection.Close();
        }

        private void DeleteData() {
            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();
            try {
                MySqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM petugas WHERE id = '"+userId+"'";
                sqlCommand.ExecuteNonQuery();
            } catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }
        }
    }
}
