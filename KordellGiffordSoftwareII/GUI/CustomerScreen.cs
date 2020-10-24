﻿using KordellGiffordSoftwareII.Controller;
using System;
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
            Repo.customers.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyCustomer modifyCustomer = new ModifyCustomer();
            modifyCustomer.Show();
        }

        //private void CustomerScreen_Load(object sender, EventArgs e)
        //{
        //    //Grab all the customers and put it into a generic list.
        //    var all = Repo.GetAllCustomers();
        //    //lambda
        //    List<Tuple<int, string>> names = all.Select(x => new Tuple<int, string>(x.customerId, x.customerName)).ToList();
        //    customerList.DataSource = names;
        //    customerList.Columns[0].HeaderText = "Customer Id";
        //    customerList.Columns[1].HeaderText = "Customer Name";
        //    customerList.Columns[0].Width = 55;
        //    customerList.ClearSelection();
        //    Repo.Index = -1;
        //}

        private void Display()
        {
            //Grab all the customers and put it into a generic list.
            var all = Repo.GetAllCustomers();
            //lambda
            List<Tuple<int, string>> names = all.Select(x => new Tuple<int, string>(x.customerId, x.customerName)).ToList();
            customerList.DataSource = names;
            customerList.Columns[0].HeaderText = "Customer Id";
            customerList.Columns[1].HeaderText = "Customer Name";
            customerList.Columns[0].Width = 55;
            customerList.ClearSelection();
            Repo.Index = -1;
        }

        private void customerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Repo.Index = customerList.CurrentCell.RowIndex;
                var all = Repo.customers;
                var current = customerList.SelectedRows[0].Cells[0].Value.ToString();

                var test = all.Where(x => x.customerId.ToString() == current).ToList().Select(y => y.customerName).ToList()[0];

                cNameResult.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.customerName).ToList()[0];
                cAddressResult.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.address).ToList()[0];
                cAddress2Result.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.address2).ToList()[0];
                cCityResult.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.city).ToList()[0];
                cCountryResult.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.country).ToList()[0];
                cPhoneResult.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.phone).ToList()[0];
                cPostalResult.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.postal).ToList()[0];
            }
            catch (Exception)
            {

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Repo.Index > -1)
            {
                try
                {
                    var customerName = customerList.SelectedRows[0].Cells[1].Value.ToString();
                    int customerId = Convert.ToInt32(customerList.SelectedRows[0].Cells[0].Value.ToString());
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {customerName}?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Repo.DeleteCustomer(customerId))
                        {
                            Display();
                            MessageBox.Show($"{customerName} has been deleted.");
                        }
                        else
                        {
                            MessageBox.Show("The product has associated parts and cannot be deleted.");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"Unable to delete customer.");
                }
            }
            else
            {
                MessageBox.Show("You must select a customer.");
            }
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            //Grab all the customers and put it into a generic list.
            var all = Repo.GetAllCustomers();
            //lambda
            List<Tuple<int, string>> names = all.Select(x => new Tuple<int, string>(x.customerId, x.customerName)).ToList();
            customerList.DataSource = names;
            customerList.Columns[0].HeaderText = "Customer Id";
            customerList.Columns[1].HeaderText = "Customer Name";
            customerList.Columns[0].Width = 55;
            customerList.ClearSelection();
            Repo.Index = -1;
        }
    }
}
