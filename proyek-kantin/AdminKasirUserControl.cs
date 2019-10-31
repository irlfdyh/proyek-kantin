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

namespace proyek_kantin
{
    public partial class AdminKasirUserControl : UserControl
    {
        public AdminKasirUserControl()
        {
            InitializeComponent();
            loadData();
        }

        string myConnection = "Server=localhost;Database=proyek-kantin;Uid=root;pwd='';";
        string userId = null;

        protected void loadData()
        {
            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();

            try {

                MySqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM kasir";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;

            } catch (Exception e) {
                throw;
                //e.Message.ToString();
            }
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userId = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

    }
}
