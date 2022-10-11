using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection_of_class.View.admin
{
    public partial class Customer_Information : Form
    {
        public Customer_Information()
        {
            InitializeComponent();
        }

        private void Customer_Information_Load(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            MySqlDataAdapter my_apdater = new MySqlDataAdapter();
            BindingSource bindingSource = new BindingSource();
            DataTable dt = new DataTable();

            string query;
            query = "select * from customer_information";
            my_apdater.SelectCommand = new MySqlCommand(query, conn.mySqlConnection);
            my_apdater.Fill(dt);
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
