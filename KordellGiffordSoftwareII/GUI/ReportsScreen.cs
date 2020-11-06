using KordellGiffordCapstone.Controller;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordCapstone
{
    public partial class ReportsScreen : Form
    {
        public ReportsScreen()
        {
            InitializeComponent();
        }
        ResourceManager rm = new ResourceManager("KordellGiffordSoftwareII.Languages.Messages", typeof(Login).Assembly);

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Reports
        private void generateBtn_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            Reports r = new Reports();
            if (reportType.Text == rm.GetString("by month", ci))
            {
                TextFillByMonth(r.ReportMonthByType());
            }
            else if (reportType.Text == rm.GetString("by user", ci))
            {
                TextFillByConsultant(r.ReportConsultantSchedule());
            }
            else if (reportType.Text == rm.GetString("by cust", ci))
            {
                TextFillByCustomer(r.ReportCustomerByType());
            }
            ci.ClearCachedData();
        }

        private void ReportsScreen_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            List<string> reportTypes = new List<string>()
            {
                rm.GetString("by month", ci),
                rm.GetString("by user", ci),
                rm.GetString("by cust", ci)
            };
            reportType.DataSource = reportTypes;
            ci.ClearCachedData();
        }

        private void TextFillByMonth(DataTable dt)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            reports.Text = rm.GetString("by month", ci) + "\r\n\r\n";
            List<string> months = new List<string>();
            months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.ToList();
            if (months.Count > 12)
            {
                months.RemoveAt(12);
            }
            months.ToArray();

            foreach (string month in months)
            {
                reports.Text = reports.Text + month + "\r\n";
                int consult = 0;
                int brief = 0;
                int review = 0;
                int other = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (month == months[((DateTime)row["start"]).Month - 1])
                    {
                        if (row["type"].ToString() == "Consulting")
                        {
                            consult++;
                        }
                        if (row["type"].ToString() == "Brief")
                        {
                            brief++;
                        }
                        if (row["type"].ToString() == "Review")
                        {
                            review++;
                        }
                        if (row["type"].ToString() == "Other")
                        {
                            other++;
                        }
                    }
                }
                reports.Text = reports.Text +
                    "\tConsulting\t" + consult + "\r\n" +
                    "\tBrief\t\t" + brief + "\r\n" +
                    "\tReview\t\t" + review + "\r\n" +
                    "\tOther\t\t" + other + "\r\n";
                reports.Select(0, 0);
            }
            ci.ClearCachedData();
        }

        private void TextFillByConsultant(DataTable dt)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            DataAccess da = new DataAccess();
            reports.Text = rm.GetString("schedule", ci) + "\r\n\r\n";
            string[] consultants = GetUsers();

            foreach (string name in consultants)
            {
                reports.Text = reports.Text + name + "\r\n";
                string startDate = "";
                string endDate = "";
                foreach (DataRow row in dt.Rows)
                {
                    if (name == row["userName"].ToString())
                    {
                        startDate = row["start"].ToString();
                        endDate = row["end"].ToString();
                        reports.Text = reports.Text +
                            "\tStart:\t" + TimeZoneInfo.ConvertTimeFromUtc(Convert.ToDateTime(startDate), TimeZoneInfo.Local) + "\tEnd:\t" + TimeZoneInfo.ConvertTimeFromUtc(Convert.ToDateTime(endDate), TimeZoneInfo.Local) + "\r\n\r";
                        reports.Select(0, 0);
                    }
                }
            }
            ci.ClearCachedData();
        }

        private void TextFillByCustomer(DataTable dt)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            reports.Text = rm.GetString("by cust", ci) + "\r\n\r\n";
            var customer = GetCustomers();

            foreach (string name in customer)
            {
                reports.Text = reports.Text + name + "\r\n";
                int consult = 0;
                int brief = 0;
                int review = 0;
                int other = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (name == row["customerName"].ToString())
                    {
                        if (row["type"].ToString() == "Consulting")
                        {
                            consult++;
                        }
                        if (row["type"].ToString() == "Brief")
                        {
                            brief++;
                        }
                        if (row["type"].ToString() == "Review")
                        {
                            review++;
                        }
                        if (row["type"].ToString() == "Other")
                        {
                            other++;
                        }
                    }
                }
                reports.Text = reports.Text +
                    "\tConsulting\t" + consult + "\r\n" +
                    "\tBrief\t\t" + brief + "\r\n" +
                    "\tReview\t\t" + review + "\r\n" +
                    "\tOther\t\t" + other + "\r\n";
                reports.Select(0, 0);
            }
            ci.ClearCachedData();
        }

        private string[] GetUsers()
        {
            DataAccess da = new DataAccess();
            List<string> users = new List<string>();
            da.OpenConnection();
            var command = new MySqlCommand("GetUsers", da.connectionS());
            command.CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    users.Add(rdr[0].ToString());
                }
            }
            da.CloseConnection();
            string[] names = users.ToArray();
            return names;
        }

        private List<string> GetCustomers()
        {
            DataAccess da = new DataAccess();
            List<string> customers = new List<string>();
            da.OpenConnection();
            var command = new MySqlCommand("GetCustomer", da.connectionS());
            command.CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    customers.Add(rdr[0].ToString());
                }
            }
            da.CloseConnection();
            return customers;
        }
        #endregion

        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);

                generateBtn.Text = rm.GetString("generate", ci);
                closeBtn.Text = rm.GetString("close", ci);
                this.Text = rm.GetString("reports", ci);
                ci.ClearCachedData();
                Alert();
            }
            catch
            {
                //intentionally open to allow display to reset without throwing errors
            }
        }

        private void Alert()
        {
            var alerts = Repo.Alerts();
            if (alerts != null)
            {
                foreach (var item in alerts)
                {
                    //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
                    Repo.appointments1.Where(x => x.appointmentId == item.Item1).ToList().ForEach(x => x.alert = 1);
                    Repo.alerted.Add(item.Item1);
                    var name = item.Item2;
                    CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                    DialogResult dialogResult = MessageBox.Show($"{name}" + rm.GetString("15", ci));
                    ci.ClearCachedData();
                }
            }
        }
        #endregion
    }
}
