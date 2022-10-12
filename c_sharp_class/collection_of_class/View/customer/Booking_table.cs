using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection_of_class.View.customer
{
    public partial class Booking_table : Form
    {
        public Booking_table()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            txt_name.Text = Login.name;
            string cname, ccontact,caddress,cdate,ctime,cservice;
            cname = txt_name.Text;
            ccontact = txt_contact.Text;
            caddress=txt_address.Text;
            cdate = dateTimePicker1.Value.Date.ToString("d");
            ctime = cbo_time.Text;
            cservice = cbo_service.Text;


            Controller.Customer_information_Controller ccic = new Controller.Customer_information_Controller();
            ccic.create_user_account(cname,ccontact,caddress,cdate,ctime,cservice);
        }
    }
}
