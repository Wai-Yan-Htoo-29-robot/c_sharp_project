using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection_of_class
{
    class CONNECT
    {
        public MySqlConnection mySqlConnection;
       private string db_info = "server=localhost;uid=root;pwd=;database=ncc";
        public CONNECT()
        {
            try
            {
                mySqlConnection = new MySqlConnection(db_info);
                mySqlConnection.Open();
            }
            catch (Exception error_message)
            {
                MessageBox.Show($"error occur : {error_message.Message}");
            }
           
            //MessageBox.Show("connection open");
        }

        ~CONNECT() { }
        
    }
}
