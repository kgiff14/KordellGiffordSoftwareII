using KordellGiffordSoftwareII.Controller;
using MySql.Data.MySqlClient;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
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
        }
    }
}
