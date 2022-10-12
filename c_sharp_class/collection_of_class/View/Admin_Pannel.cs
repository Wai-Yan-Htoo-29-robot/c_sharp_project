using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection_of_class.View
{
    public partial class Admin_Pannel : Form
    {
        public Admin_Pannel()
        {
            InitializeComponent();
        }

        Controller.User_Account_Controller cuac;
        private void btn_select_Click(object sender, EventArgs e)
        {
            View.admin.Customer_Information customer_information = new View.admin.Customer_Information();
            
            customer_information.Show();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            User_Registration ur = new User_Registration();
            ur.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
