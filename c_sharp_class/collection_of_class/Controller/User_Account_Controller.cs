using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection_of_class.Controller
{
    class User_Account_Controller
    {
        public CONNECT db_conn;
        public MySqlDataAdapter adapter;
        public MySqlCommand command;
        string sql="";


        public void create_user_account(string cName,string cPassword)
        {
            //insert into database
            //Notes : when we do process with database whatever you want(crud = create,read,update,delete)
            //Have many way I will describe two way for insert, other are also too

            sql = "insert into user_account(name,passwrod) values('" + cName + "','" + cPassword + "')";
            try
            {
                //first way
                /*
                adapter = new MySqlDataAdapter();
                db_conn = new CONNECT();
                command = new MySqlCommand(sql, db_conn.mySqlConnection);
                adapter.InsertCommand = new MySqlCommand(sql, db_conn.mySqlConnection);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                */

                //second way
                db_conn = new CONNECT();
                command = db_conn.mySqlConnection.CreateCommand();
                command.CommandText= sql;
                command.ExecuteNonQuery();
                db_conn.mySqlConnection.Close();
                
                MessageBox.Show("user regristration successful");
            }
            catch (Exception error_message)
            {
                MessageBox.Show("Error occur : " + error_message.Message);
            }
        }
        public void update_custinfo()
        {
            //update data
            //sql = "update customer_information set ";
            //db_conn = new CONNECT();
            //command = db_conn.mySqlConnection.CreateCommand();
            //command.CommandText = sql;
            //command.ExecuteNonQuery();
            //db_conn.mySqlConnection.Close();
            
        }

        public void delete_custinfo()
        {
            //delete data
        }

        public void read_custinfo()
        {
            //select from database
            sql = "select * from user_account";
            db_conn = new CONNECT();
            command = db_conn.mySqlConnection.CreateCommand();
            command.CommandText = sql;
            

           // db_conn.mySqlConnection.Close();
        }

    }
}
