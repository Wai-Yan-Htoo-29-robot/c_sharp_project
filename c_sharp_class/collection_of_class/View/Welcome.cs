﻿using System;
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
    }
}