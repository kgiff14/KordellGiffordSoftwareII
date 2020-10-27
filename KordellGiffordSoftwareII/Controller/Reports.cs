using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KordellGiffordSoftwareII
{
    class Reports
    {
        public DataTable ReportMonthByType()
        {
            try
            {
                DataTable dt = new DataTable();
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("ReportTypeByMonth", da.connectionS());
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter apd = new MySqlDataAdapter(command);
                apd.Fill(dt);
                da.CloseConnection();

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                return null;
            }
        }

        public DataTable ReportConsultantSchedule()
        {
            try
            {
                DataTable dt = new DataTable();
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("ReportConsultant", da.connectionS());
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter apd = new MySqlDataAdapter(command);
                apd.Fill(dt);
                da.CloseConnection();

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                return null;
            }
        }

        public DataTable ReportCustomerByType()
        {
            try
            {
                DataTable dt = new DataTable();
                DataAccess da = new DataAccess();
                da.OpenConnection();
                var command = new MySqlCommand("ReportTypeByCustomer", da.connectionS());
                command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter apd = new MySqlDataAdapter(command);
                apd.Fill(dt);
                da.CloseConnection();

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                return null;
            }
        }
    }
}
