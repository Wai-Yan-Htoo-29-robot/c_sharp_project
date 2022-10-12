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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string name, password;
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            name=txt_name.Text;
            password=txt_password.Text; 
            Controller.User_Account_Controller cuac = new Controller.User_Account_Controller();
            cuac.read_custinfo(name,password);
        }
    }
}
