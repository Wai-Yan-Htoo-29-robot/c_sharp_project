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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_reserve_table_Click(object sender, EventArgs e)
        {

            customer.Booking_table cbt = new customer.Booking_table();
            cbt.TopLevel = false;
            cbt.AutoScroll = true;
            panel5.Controls.Add(cbt);
            cbt.BringToFront();
            cbt.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            btn_account.Text = Login.name;
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

        }
    }
}
