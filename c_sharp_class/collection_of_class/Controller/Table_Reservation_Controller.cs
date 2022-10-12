using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection_of_class.Controller
{
    internal class Table_Reservation_Controller
    {
        public CONNECT db_conn;
        public MySqlDataAdapter adapter;
        public MySqlCommand command;
        string sql = "";
        public void create_user_account(string cName, string cDate, string cTime, string cPrice)
        {
            //insert into database
            //Notes : when we do process with database whatever you want(crud = create,read,update,delete)
            //Have many way I will describe two way for insert, other are also too

            sql = "insert into customer_information(name,date,time,price) values('" + cName + "','" + cDate + "','" + cTime + "','" + cPrice + "')";
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
                command.CommandText = sql;
                command.ExecuteNonQuery();
                db_conn.mySqlConnection.Close();

                MessageBox.Show("Booking successful");
            }
            catch (Exception error_message)
            {
                MessageBox.Show("Error occur in customer information controller : " + error_message.Message);
            }
        }
    }
}
