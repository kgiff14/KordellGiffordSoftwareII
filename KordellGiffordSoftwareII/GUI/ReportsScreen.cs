using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
        }

        private void TextFillByMonth(DataTable dt)
        {
            reports.Text = "Number of each type, by month\r\n\r\n";
            string[] months;
            months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            foreach (string month in months)
            {
                reports.Text = reports.Text + month + "\r\n";
                int consult = 0;
                int brief = 0;
                int review = 0;
                int other = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (month == months[((DateTime)row["start"]).Month - 4])
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
                    "\tConsulting\t\t" + consult + "\r\n" +
                    "\tBrief\t\t" + brief + "\r\n" +
                    "\tReview\t\t" + review + "\r\n" +
                    "\tOther\t\t" + other + "\r\n";
                reports.Select(0, 0);
            }
        }

        private void TextFillByConsultant(DataTable dt)
        {
            reports.Text = "Schedule by Consultant\r\n\r\n";
            string[] consultants;
            //This is a LINQ to Object expression, Applying a lambda expression is a simpler and easy to read syntax.
            consultants = dt.Select(x => x.userName).ToList();

            foreach (string name in consultants)
            {
                reports.Text = reports.Text + name + "\r\n";
                string startDate = "";
                string endDate = "";
                foreach (DataRow row in dt.Rows)
                {
                    if (name == consultants[row["userName"].ToString()])
                    {
                        startDate = row["start"].ToString();
                        endDate = row["end"].ToString();
                        reports.Text = reports.Text +
                            "\tStart:\t" + startDate + "\tEnd:\t" + endDate;
                        reports.Select(0, 0);
                    }
                }
            }
        }

        private void TextFillByCustomer(DataTable dt)
        {
            reports.Text = "Number of each type, by customer\r\n\r\n";
            string[] customer;
            //This is a LINQ to Object expression, Applying a lambda expression is a simpler and easy to read syntax.
            customer = dt.Select(x => x.customerName).ToList();

            foreach (string name in customer)
            {
                reports.Text = reports.Text + name + "\r\n";
                int consult = 0;
                int brief = 0;
                int review = 0;
                int other = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (name == customer[row["customerName"].ToString()])
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
                    "\tConsulting\t\t" + consult + "\r\n" +
                    "\tBrief\t\t" + brief + "\r\n" +
                    "\tReview\t\t" + review + "\r\n" +
                    "\tOther\t\t" + other + "\r\n";
                reports.Select(0, 0);
            }
        }
    }
}
