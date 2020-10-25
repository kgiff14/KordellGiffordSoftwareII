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
        public static List<Appointments> appointments1 = new List<Appointments>();
        public static int Index;
        public static int IndexItem;
        public static Tuple<int, string> uId { get; set; }

        #region Customer Manipulation
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
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("DeleteCustomer", da.connectionS());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command.ExecuteNonQuery();
                da.CloseConnection();

                return true;
            }
            catch (Exception e)
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
                command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = Repo.uId.Item2;
                command.ExecuteNonQuery();
                da.CloseConnection();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool ModifyCustomer(Customers customers)
        {
            try
            {
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("ModifyCustomer", da.connectionS());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = customers.customerId;
                command.Parameters.Add("@customer", MySqlDbType.VarChar).Value = customers.customerName;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = customers.address;
                command.Parameters.Add("@address2", MySqlDbType.VarChar).Value = customers.address2;
                command.Parameters.Add("@city", MySqlDbType.Int32).Value = customers.city;
                command.Parameters.Add("@postal", MySqlDbType.VarChar).Value = customers.postal;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customers.phone;
                command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = Repo.uId.Item2;
                command.ExecuteNonQuery();
                da.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        public static bool AddAppointment(Appointments appointments)
        {
            try
            {
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("AddAppointment", da.connectionS());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@cId", MySqlDbType.VarChar).Value = appointments.customerId;
                command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = appointments.userId;
                command.Parameters.Add("@title", MySqlDbType.VarChar).Value = appointments.title;
                command.Parameters.Add("@description", MySqlDbType.Text).Value = appointments.description;
                command.Parameters.Add("@location", MySqlDbType.Text).Value = appointments.location;
                command.Parameters.Add("@contact", MySqlDbType.Text).Value = appointments.contact;
                command.Parameters.Add("@type2", MySqlDbType.Text).Value = appointments.type;
                command.Parameters.Add("@url", MySqlDbType.VarChar).Value = appointments.url;
                command.Parameters.Add("@start2", MySqlDbType.DateTime).Value = appointments.start;
                command.Parameters.Add("@end2", MySqlDbType.DateTime).Value = appointments.end;
                command.Parameters.Add("@date2", MySqlDbType.DateTime).Value = DateTime.UtcNow;
                command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = Repo.uId.Item2;
                command.ExecuteNonQuery();
                da.CloseConnection();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static List<Appointments> GetAppointments()
        {
            try
            {
                Repo.appointments1.Clear();

                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("GetAppointments", da.connectionS());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@uId", MySqlDbType.Int32).Value = Repo.uId.Item1;
                using (MySqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        appointments1.Add(new Appointments(Convert.ToInt32(rdr["appointmentId"]), Convert.ToInt32(rdr["customerId"]), Convert.ToInt32(rdr["userId"]),
                            rdr["title"].ToString(), rdr["description"].ToString(), rdr["location"].ToString(), rdr["contact"].ToString(),
                            rdr["type"].ToString(), rdr["url"].ToString(), Convert.ToDateTime(rdr["start"]), Convert.ToDateTime(rdr["end"])));
                    }
                }
                da.CloseConnection();

                return Repo.appointments1;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public static bool DeleteAppointment(int id)
        {
            try
            {
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("DeleteAppointment", da.connectionS());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command.ExecuteNonQuery();
                da.CloseConnection();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool ModifyAppointment(Appointments appointments)
        {
            try
            {
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("ModifyAppointment", da.connectionS());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@cId", MySqlDbType.VarChar).Value = appointments.customerId;
                command.Parameters.Add("@aId", MySqlDbType.VarChar).Value = appointments.appointmentId;
                command.Parameters.Add("@title", MySqlDbType.VarChar).Value = appointments.title;
                command.Parameters.Add("@description", MySqlDbType.Text).Value = appointments.description;
                command.Parameters.Add("@location", MySqlDbType.Text).Value = appointments.location;
                command.Parameters.Add("@contact", MySqlDbType.Text).Value = appointments.contact;
                command.Parameters.Add("@type2", MySqlDbType.Text).Value = appointments.type;
                command.Parameters.Add("@url", MySqlDbType.VarChar).Value = appointments.url;
                command.Parameters.Add("@start2", MySqlDbType.DateTime).Value = appointments.start;
                command.Parameters.Add("@end2", MySqlDbType.DateTime).Value = appointments.end;
                command.Parameters.Add("@date2", MySqlDbType.DateTime).Value = DateTime.UtcNow;
                command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = Repo.uId.Item2;
                command.ExecuteNonQuery();
                da.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
