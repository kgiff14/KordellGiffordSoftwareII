using KordellGiffordSoftwareII.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordSoftwareII
{
    public partial class ModifyCustomer : Form
    {
        public ModifyCustomer()
        {
            InitializeComponent();
        }
        ResourceManager rm = new ResourceManager("KordellGiffordSoftwareII.Languages.Messages", typeof(Login).Assembly);

        private void canceBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }

        private void ModifyCustomer_Load(object sender, EventArgs e)
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

            //customerInfo
            var all = Repo.customers;
            var current = Repo.Index.ToString();

            //Following are LINQ expressions querying the customers list from Repo.. Allows for temporary modification of 
            //data without saving it to the database first.

            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            nameIn.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.customerName).ToList()[0];
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            addressIn.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.address).ToList()[0];
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            address2In.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.address2).ToList()[0];
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            cityIn.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.city).ToList()[0];
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            countryIn.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.country).ToList()[0];
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            phoneIn.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.phone).ToList()[0];
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            postalIn.Text = all.Where(x => x.customerId.ToString() == current).ToList().Select(x => x.postal).ToList()[0];
            cityIn.BackColor = Color.White;
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var tempId = Repo.Index;
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

            Customers add = new Customers(tempId, name, address, address2, postal, city, country, phone);

            if (Repo.ModifyCustomer(add))
            {
                CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                MessageBox.Show(rm.GetString("cust update", ci));
                ci.ClearCachedData();
                this.Close();
                CustomerScreen customerScreen = new CustomerScreen();
                customerScreen.Show();
            }
            else
            {
                CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                MessageBox.Show(rm.GetString("cust not updated", ci));
                ci.ClearCachedData();
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);

            ResourceManager rm = new ResourceManager("KordellGiffordSoftwareII.Languages.Messages", typeof(Login).Assembly);
            cName.Text = rm.GetString("title", ci);
            cAddress.Text = rm.GetString("address", ci);
            this.Text = rm.GetString("modify", ci);
            cAddress2.Text = rm.GetString("address2", ci);
            cCity.Text = rm.GetString("city", ci);
            saveBtn.Text = rm.GetString("save", ci);
            cPostal.Text = rm.GetString("postal", ci);
            cCountry.Text = rm.GetString("country", ci);
            cPhone.Text = rm.GetString("phone", ci);
            canceBtn.Text = rm.GetString("cancel", ci);
            ci.ClearCachedData();
        }
    }
}
