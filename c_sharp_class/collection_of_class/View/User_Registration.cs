using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace collection_of_class.View
{
    public partial class User_Registration : Form
    {
        public User_Registration()
        {
            InitializeComponent();
        }
        Controller.User_Account_Controller cuac;
        private void btn_register_Click(object sender, EventArgs e)
        {
            string name, password;
            try
            {
                name = txt_name.Text;
                password = txt_password.Text;
                if (name=="" || password == "")
                {
                    MessageBox.Show("empty value");
                }
                else
                {
                    cuac = new Controller.User_Account_Controller();
                    cuac.create_user_account(name, password);
                    //this.Hide();
                }

               
            }
            catch(Exception errormessage)
            {
                MessageBox.Show($" error occur : {errormessage}");
            }
           
            
        }
    }
}
