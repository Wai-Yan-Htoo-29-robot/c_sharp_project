using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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


        Controller.Customer_information_Controller ccic = new Controller.Customer_information_Controller();
        Controller.Table_Reservation_Controller ctrc = new Controller.Table_Reservation_Controller();
     

        private void btn_confirm_Click(object sender, EventArgs e)
        {
           
            string cname, cdate, ctime,ccontact, caddress, cservice;
            float price=0;
            cname = txt_name.Text;
            ccontact = txt_contact.Text;
            caddress=txt_address.Text;
            cdate = dateTimePicker1.Value.Date.ToString("d");
            ctime = cbo_time.Text;
            cservice = cbo_service.Text;
            if (cbo_service.SelectedIndex == 0)
            {
                price = 10000f;
            }
            else if(cbo_service.SelectedIndex == 1)
            {
                price = 20000;
            }
            else if(cbo_service.SelectedIndex==2)
            {
                price = 30000;
            }

            
            if (ctrc.order_confirm(cname, ctime, cdate) == true)
            {
                MessageBox.Show("Are you sure ? \nPlease reconfirm order ");
            }
            else
            {
                ccic.create_user_account(cname, ccontact, caddress, cdate, ctime, cservice);

                ctrc = new Controller.Table_Reservation_Controller();
                ctrc.table_reserve(cname, cdate, ctime, price.ToString());
            }


        }

        private void Booking_table_Load(object sender, EventArgs e)
        {
            txt_name.Text = Login.name;
        }

     
    }
}
