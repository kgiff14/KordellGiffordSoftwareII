using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordellGiffordSoftwareII
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

        //public bool DeleteCustomer(int id)
        //{

        //}

        //public bool ModifyCustomer(int id)
        //{

        //}

        //public bool AddCustomer(Customers customers)
        //{

        //}

        //public Customers LookupCustomer(int id)
        //{

        //}

        //public List<string> GetAllCustomers()
        //{
        //    DataAccess da = new DataAccess();
        //    List<string> cList = new List<string>();
        //    da.OpenConnection();
        //    using (var command = new SqlCommand("GetAllCustomers") { CommandType = System.Data.CommandType.StoredProcedure })
        //    {
        //        using (SqlDataReader rdr = command.ExecuteReader())
        //        {
        //            while (rdr.Read())
        //            {
        //                cList.Add(new Customers(Convert.ToInt32(rdr["customerId"]), rdr["customerName"].ToString(), Convert.ToInt32(rdr["addressId"]), Convert.ToSByte(rdr["active"]), 
        //                    Convert.ToDateTime(rdr["createDate"]), rdr["createdBy"].ToString(), Convert.ToDateTime(rdr["lastUpdateBy"]), rdr["lastUpdateBy"].ToString()));
        //            }
        //        }
        //    }
        //    da.CloseConnection();
        //    return customers;
        //}
    }
}
