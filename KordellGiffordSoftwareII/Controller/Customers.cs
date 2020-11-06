using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordellGiffordCapstone
{
    public class Customers
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string postal { get; set; }
        public string country { get; set; }
        public string phone { get; set; }

        public List<Customers> customers = new List<Customers>();

        public Customers(int customerId, string customerName, string address, string address2, string postal,string city,string country, string phone)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.address = address;
            this.address2 = address2;
            this.postal = postal;
            this.country = country;
            this.phone = phone;
            this.city = city;
        }

    }
}
