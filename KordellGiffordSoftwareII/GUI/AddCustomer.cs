﻿using KordellGiffordSoftwareII.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordSoftwareII
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            AllowSave();
        }

        private void canceBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var tempId = 0;
            var name = nameIn.Text;
            var address = addressIn.Text;
            var address2 = address2In.Text;
            var city = cityIn.Text;
            switch (city)
            {
                case "Phoenix":
                    city = "1";
                    break;
                case "New York":
                    city = "2";
                    break;
                case "London":
                    city = "3";
                    break;
            }
            var postal = postalIn.Text;
            var country = countryIn.Text;
            switch (country)
            {
                case "USA":
                    country = "1";
                    break;
                case "United Kingdom":
                    country = "2";
                    break;
            }
            var phone = phoneIn.Text.ToString();

            Customers add = new Customers(tempId,name,address,address2,postal,city,country,phone);

            if (Repo.AddCustomer(add))
            {
                MessageBox.Show("Customer has been added.");
                this.Close();
                CustomerScreen customerScreen = new CustomerScreen();
                customerScreen.Show();
            }
            else
            {
                MessageBox.Show("Unable to add new customer");
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            //adding cities
            List<string> cities = new List<string>();
            DataAccess da = new DataAccess();
            da.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT city FROM city;", da.connectionS());
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    cities.Add(rdr[0].ToString());
                }
            }
            cityIn.DataSource = cities;
            da.CloseConnection();
            //adding countries
            da.OpenConnection();
            List<string> countries = new List<string>();
            MySqlCommand cmd2 = new MySqlCommand("SELECT country FROM country;", da.connectionS());
            using (MySqlDataReader rdr2 = cmd2.ExecuteReader())
            {
                while (rdr2.Read())
                {
                    countries.Add(rdr2[0].ToString());
                }
            }
            countryIn.DataSource = countries;
            da.CloseConnection();
            cityIn.BackColor = Color.White;
        }

        private void AllowSave()
        {
            if (addressIn.BackColor == Color.White && address2In.BackColor == Color.White && nameIn.BackColor == Color.White && postalIn.BackColor == Color.White && countryIn.BackColor == Color.White
                && cityIn.BackColor == Color.White && phoneIn.BackColor == Color.White)
            {
                saveBtn.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
            }
        }

        private void nameIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameIn.Text) || nameIn.Text.All(char.IsDigit))
            {
                nameIn.BackColor = Color.Salmon;
            }
            else
            {
                nameIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void addressIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressIn.Text))
            {
                addressIn.BackColor = Color.Salmon;
            }
            else
            {
                addressIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void address2In_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(address2In.Text))
            {
                address2In.BackColor = Color.Salmon;
            }
            else
            {
                address2In.BackColor = Color.White;
            }
            AllowSave();
        }

        private void postalIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(postalIn.Text) || postalIn.Text.Length != 5)
            {
                postalIn.BackColor = Color.Salmon;
            }
            else
            {
                postalIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void phoneIn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(phoneIn.Text) || Regex.IsMatch(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$", phoneIn.Text) || phoneIn.Text.Length != 12)
                {
                    phoneIn.BackColor = Color.Salmon;
                }
                else
                {
                    phoneIn.BackColor = Color.White;
                }
                AllowSave();
            }
            catch
            {
                //intentionally empty
            }
        }

        private void cityIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cityIn.Text == "Phoenix" && countryIn.Text == "USA") || (cityIn.Text == "New York" && countryIn.Text == "USA") || (cityIn.Text == "London" && countryIn.Text == "United Kingdom"))
            {
                cityIn.BackColor = Color.White;
            }
            else
            {
                cityIn.BackColor = Color.Salmon;
            }
        }

        private void countryIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cityIn.Text == "Phoenix" && countryIn.Text == "USA") || (cityIn.Text == "New York" && countryIn.Text == "USA") || (cityIn.Text == "London" && countryIn.Text == "United Kingdom"))
            {
                countryIn.BackColor = Color.White;
            }
            else
            {
                countryIn.BackColor = Color.Salmon;
            }
        }
    }
}