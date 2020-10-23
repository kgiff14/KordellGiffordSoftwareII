using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordSoftwareII
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Calendar Population
        private void MainScreen_Load(object sender, EventArgs e)
        {
            monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Now.Month);
            yearLabel.Text = DateTime.Now.Year.ToString();
            int day = DateTime.Now.Day;
            string month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Now.Month);// should be in the format of Jan, Feb, Mar, Apr, etc...
            int yearofMonth = DateTime.Now.Year;
            DateTime dateTime = Convert.ToDateTime("01-" + month + "-" + yearofMonth);
            DataRow dr;
            DataTable dt = new DataTable();
            dt.Columns.Add("Sunday");
            dt.Columns.Add("Monday");
            dt.Columns.Add("Tuesday");
            dt.Columns.Add("Wednesday");
            dt.Columns.Add("Thursday");
            dt.Columns.Add("Friday");
            dt.Columns.Add("Saturday");
            dr = dt.NewRow();
            for (int i = 0; i < DateTime.DaysInMonth(dateTime.Year, dateTime.Month); i += 1)
            {
                if (Convert.ToDateTime(dateTime.AddDays(i)).ToString("dddd") == "Sunday")
                {
                    dr["Sunday"] = i + 1;
                }
                if (Convert.ToDateTime(dateTime.AddDays(i)).ToString("dddd") == "Monday")
                {
                    dr["Monday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Tuesday")
                {
                    dr["Tuesday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Wednesday")
                {
                    dr["Wednesday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Thursday")
                {
                    dr["Thursday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Friday")
                {
                    dr["Friday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Saturday")
                {
                    dr["Saturday"] = i + 1;
                    dt.Rows.Add(dr);
                    dr = dt.NewRow();
                    continue;
                }
            }

            calendar.DataSource = dt;
            calendar.ClearSelection();
            int count = 0;
            foreach (DataGridViewRow row in calendar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == day.ToString())
                    {
                        cell.Selected = true;
                        WeekView(count, cell.Value);
                        return;
                    }
                }
                count++;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var newDate = dateTimePicker1.Value;
            var newMonth = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(newDate.Month);
            var newYear = newDate.Year.ToString(); ;
            var newDay = newDate.Day.ToString();
            DateChange(newMonth, newYear, newDay);
        }

        private void DateChange(string month, string year, string day)
        {
            monthLabel.Text = month;
            yearLabel.Text = year;
            DateTime dateTime = Convert.ToDateTime("01-" + month + "-" + year);
            DataRow dr;
            DataTable dt = new DataTable();
            dt.Columns.Add("Sunday");
            dt.Columns.Add("Monday");
            dt.Columns.Add("Tuesday");
            dt.Columns.Add("Wednesday");
            dt.Columns.Add("Thursday");
            dt.Columns.Add("Friday");
            dt.Columns.Add("Saturday");
            dr = dt.NewRow();
            for (int i = 0; i < DateTime.DaysInMonth(dateTime.Year, dateTime.Month); i += 1)
            {
                if (Convert.ToDateTime(dateTime.AddDays(i)).ToString("dddd") == "Sunday")
                {
                    dr["Sunday"] = i + 1;
                }
                if (Convert.ToDateTime(dateTime.AddDays(i)).ToString("dddd") == "Monday")
                {
                    dr["Monday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Tuesday")
                {
                    dr["Tuesday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Wednesday")
                {
                    dr["Wednesday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Thursday")
                {
                    dr["Thursday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Friday")
                {
                    dr["Friday"] = i + 1;
                }
                if (dateTime.AddDays(i).ToString("dddd") == "Saturday")
                {
                    dr["Saturday"] = i + 1;
                    dt.Rows.Add(dr);
                    dr = dt.NewRow();
                    continue;
                }
            }

            calendar.DataSource = dt;
            calendar.ClearSelection();
            int count = 0;
            foreach (DataGridViewRow row in calendar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == day.ToString())
                    {
                        var thisWeek = row.Clone();
                        cell.Selected = true;
                        WeekView(count, cell.Value);
                        return;
                    }
                }
                count++;
            }
        }

        private void WeekView(int count, object cell)
        {
            DataRow dr;
            DataTable dt = new DataTable();
            dt.Columns.Add("Sunday");
            dt.Columns.Add("Monday");
            dt.Columns.Add("Tuesday");
            dt.Columns.Add("Wednesday");
            dt.Columns.Add("Thursday");
            dt.Columns.Add("Friday");
            dt.Columns.Add("Saturday");
            dr = dt.NewRow();
            var test = calendar.Rows[count];
            for (var i = 0; i < test.Cells.Count; i++)
            {
                dr[i] = test.Cells[i].Value;
            }
            dt.Rows.Add(dr);
            weekCal.DataSource = dt;
            weekCal.ClearSelection();
            foreach (DataGridViewRow row in weekCal.Rows)
            {
                foreach (DataGridViewCell data in row.Cells)
                {
                    if (data.Value == cell)
                    {
                        data.Selected = true;
                        return;
                    }
                }
            }
        }

        private void calendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = calendar.CurrentRow.Index;
            var cell = calendar.CurrentCell.Value;
            WeekView(row, cell);
        }
        #endregion

        private void customerRecords_Click(object sender, EventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ReportsScreen reportsScreen = new ReportsScreen();
            reportsScreen.Show();
        }
    }
}
