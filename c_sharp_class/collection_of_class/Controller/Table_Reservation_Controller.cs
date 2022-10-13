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
        public void table_reserve(string cName, string cContact, string cDate, string cTime, string cReserve_sevice,string cPrice)
        {
            //insert into database
            //Notes : when we do process with database whatever you want(crud = create,read,update,delete)
            //Have many way I will describe two way for insert, other are also too

            sql = "insert into table_order(name,contact,date,time,reserve_title,price) values('" + cName + "','"+cContact+"','" + cDate + "','" + cTime + "','"+cReserve_sevice+"','" + cPrice + "')";
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

                //MessageBox.Show("Booking successful");
            }
            catch (Exception error_message)
            {
                MessageBox.Show("Error occur in table reserve controller : " + error_message.Message);
            }
        }

       
        public bool order_confirm(string cName,string cContact,string cDate,string cTime,string cReserve_sevice)
        {
            
            string n="", d="", t="", c="", r="";
            MySqlDataReader reader;
            //select from database
            sql = "select name,contact,date,time,reserve_title from table_order where name='" + cName
                + "' and contact='" + cContact + "' and date='" + cDate + "' and time='"+cTime+"' and reserve_title='"+cReserve_sevice+"'";
            try
            {
                db_conn = new CONNECT();
                command = db_conn.mySqlConnection.CreateCommand();
                command.CommandText = sql;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    n = reader.GetValue(0).ToString();
                    c = reader.GetValue(1).ToString();
                    d = reader.GetValue(2).ToString();
                    t = reader.GetValue(3).ToString();
                    r = reader.GetValue(4).ToString();
                    //MessageBox.Show($"{reader.GetValue(0)}{reader.GetValue(1)}{reader.GetValue(2)}{reader.GetValue(3)}{reader.GetValue(4)}");

                }
                //MessageBox.Show($" {n}\n{c}\n{d}\n{t}\n{r}");
            }
            catch (Exception error_message)
            {
                MessageBox.Show("Error occur : " + error_message.Message);
            }


            if (n != cName && d != cDate && t!=cTime && c!=cContact && r!=cReserve_sevice)
            {
                
                return true;
            }
            else
            {
                
                return false;
            }

            // db_conn.mySqlConnection.Close();
        }
    }
}
