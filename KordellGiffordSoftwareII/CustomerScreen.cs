﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordSoftwareII
{
    public partial class CustomerScreen : Form
    {
        public CustomerScreen()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            ModifyCustomer modifyCustomer = new ModifyCustomer();
            modifyCustomer.Show();
        }
    }
}