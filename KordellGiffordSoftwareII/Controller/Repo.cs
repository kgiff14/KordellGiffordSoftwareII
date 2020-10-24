using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KordellGiffordSoftwareII.Controller
{
    public static class Repo
    {
        public static List<Customers> customers = new List<Customers>();
        public static int Index;

        public static List<Customers> GetAllCustomers()
        {
            customers.Clear();
            DataAccess da = new DataAccess();
            da.OpenConnection();
            var command = new MySqlCommand("GetAllCustomers", da.connectionS());
            command.CommandType = System.Data.CommandType.StoredProcedure;
            using (MySqlDataReader rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    customers.Add(new Customers(Convert.ToInt32(rdr["customerId"]), rdr["customerName"].ToString(), rdr["address"].ToString(), rdr["address2"].ToString(),
                           rdr["postalCode"].ToString(), rdr["city"].ToString(), rdr["country"].ToString(), rdr["phone"].ToString()));
                }
            }
            da.CloseConnection();
            return customers;
        }

        public static bool DeleteCustomer(int id)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddCustomer(Customers customers)
        {
            try
            {
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("AddCustomer", da.connectionS());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@customer", MySqlDbType.VarChar).Value = customers.customerName;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = customers.address;
                command.Parameters.Add("@address2", MySqlDbType.VarChar).Value = customers.address2;
                command.Parameters.Add("@cityId", MySqlDbType.Int32).Value = customers.city;
                command.Parameters.Add("@postal", MySqlDbType.VarChar).Value = customers.postal;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customers.phone;
                command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = "kgifford";
                command.ExecuteNonQuery();
                da.CloseConnection();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public Customers LookupCustomer(int id)
        //{
        //    DataAccess da = new DataAccess();
        //    da.OpenConnection();
        //    var command = new MySqlCommand("LookupCustomer", da.connectionS());
        //    command.CommandType = System.Data.CommandType.StoredProcedure;
        //    command.Parameters.Add(id);
        //    using (MySqlDataReader rdr = command.ExecuteReader())
        //    {
        //        while (rdr.Read())
        //        {
        //            customers.Add();
        //        }
        //    }
        //    da.CloseConnection();
        //    return customers;
        //}
    }
}
