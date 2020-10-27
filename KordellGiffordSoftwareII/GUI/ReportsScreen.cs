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

namespace KordellGiffordSoftwareII
{
    public partial class ReportsScreen : Form
    {
        public ReportsScreen()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            switch (reportType.Text)
            {
                case ("Meeting types by month"):
                    TextFillByMonth(r.ReportMonthByType());
                    break;
                case ("Each consultant schedule"):
                    TextFillByConsultant(r.ReportConsultantSchedule());
                    break;
                case ("Meeting types by customer"):
                    TextFillByCustomer(r.ReportCustomerByType());
                    break;
            }
        }

        private void ReportsScreen_Load(object sender, EventArgs e)
        {
            List<string> reportTypes = new List<string>()
            {
                "Meeting types by month",
                "Each consultant schedule",
                "Meeting types by customer"
            };
            reportType.DataSource = reportTypes;
        }

        private void TextFillByMonth(DataTable dt)
        {
            reports.Text = "Number of each type, by month\r\n\r\n";
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
        }

        private void TextFillByConsultant(DataTable dt)
        {
            DataAccess da = new DataAccess();
            reports.Text = "Schedule by Consultant\r\n\r\n";
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
                            "\tStart:\t" + startDate + "\tEnd:\t" + endDate +"\r\n\r";
                        reports.Select(0, 0);
                    }
                }
            }
        }

        private void TextFillByCustomer(DataTable dt)
        {
            reports.Text = "Number of each type, by customer\r\n\r\n";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);

            ResourceManager rm = new ResourceManager("KordellGiffordSoftwareII.Languages.Messages", typeof(Login).Assembly);
            generateBtn.Text = rm.GetString("generate", ci);
            closeBtn.Text = rm.GetString("close", ci);
            this.Text = rm.GetString("login", ci);
            ci.ClearCachedData();
        }
    }
}
