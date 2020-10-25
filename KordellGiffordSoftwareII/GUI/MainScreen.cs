using KordellGiffordSoftwareII.Controller;
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

        DataAccess da = new DataAccess();

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Calendar Population
        private void MainScreen_Load(object sender, EventArgs e)
        {
            Repo.IndexItem = -1;
            monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.UtcNow.Month);
            yearLabel.Text = DateTime.UtcNow.Year.ToString();
            int day = DateTime.UtcNow.Day;
            string month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.UtcNow.Month);// should be in the format of Jan, Feb, Mar, Apr, etc...
            int yearofMonth = DateTime.UtcNow.Year;
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
            Repo.Index = -1;
            Repo.GetAppointments();
            int count = 0;
            foreach (DataGridViewRow row in calendar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == day.ToString())
                    {
                        cell.Selected = true;
                        WeekView(count, cell.Value);
                        var date = Convert.ToDateTime(string.Concat(monthLabel.Text, cell.Value, ",", yearLabel.Text));
                        AppointmentsDisplay(date);
                        return;
                    }
                }
                count++;
            }
            appointmentsTable.ClearSelection();

            

        }

        public void Display()
        {
            Repo.IndexItem = -1;
            monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.UtcNow.Month);
            yearLabel.Text = DateTime.UtcNow.Year.ToString();
            int day = DateTime.UtcNow.Day;
            string month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.UtcNow.Month);// should be in the format of Jan, Feb, Mar, Apr, etc...
            int yearofMonth = DateTime.UtcNow.Year;
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
            Repo.Index = -1;
            Repo.GetAppointments();
            int count = 0;
            foreach (DataGridViewRow row in calendar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == day.ToString())
                    {
                        cell.Selected = true;
                        WeekView(count, cell.Value);
                        var date = Convert.ToDateTime(string.Concat(monthLabel.Text, cell.Value, ",", yearLabel.Text));
                        AppointmentsDisplay(date);
                        return;
                    }
                }
                count++;
            }
            appointmentsTable.ClearSelection();
        }

        public void AppointmentsDisplay(DateTime time)
        {
            //lambda
            List<Tuple<int, string, DateTime, DateTime>> apt = Repo.appointments1.Where(x => x.start.Day == time.Day)
                .Select(x => new Tuple<int, string, DateTime, DateTime>(x.appointmentId, x.title, TimeZoneInfo.ConvertTimeFromUtc((DateTime)x.start, TimeZoneInfo.Local), TimeZoneInfo.ConvertTimeFromUtc((DateTime)x.end, TimeZoneInfo.Local))).ToList();
            appointmentsTable.DataSource = apt;
            appointmentsTable.Columns[0].HeaderText = "Appointment Id";
            appointmentsTable.Columns[0].Visible = false;
            appointmentsTable.Columns[1].HeaderText = "Appointment Title";
            appointmentsTable.Columns[2].HeaderText = "Start Time";
            appointmentsTable.Columns[3].HeaderText = "End Time";
            appointmentsTable.ClearSelection();
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
            Repo.IndexItem = -1;
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
                        var date = Convert.ToDateTime(string.Concat(monthLabel.Text, cell.Value, ",", yearLabel.Text));
                        AppointmentsDisplay(date);
                        return;
                    }
                }
                count++;
            }
            appointmentsTable.ClearSelection();
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
            var date = Convert.ToDateTime(string.Concat(monthLabel.Text, cell, ",", yearLabel.Text));
            AppointmentsDisplay(date);
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

        private void addAppBtn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
        }

        private void updateAptBtn_Click(object sender, EventArgs e)
        {
            if (Repo.IndexItem < 0)
            {
                MessageBox.Show("You must first select an appointment.");
            }
            else
            {
                ModifyAppointment modifyAppointment = new ModifyAppointment();
                modifyAppointment.Show();
            }
        }

        private void deleteAptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Repo.IndexItem < 0)
                {
                    MessageBox.Show("You must select an appointment first.");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Repo.DeleteAppointment(Repo.IndexItem))
                        {
                            MessageBox.Show("Appointment has been deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete appointment.");
                        }
                    }
                    this.Display();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to delete");
            }
        }

        private void appointmentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Repo.IndexItem = Convert.ToInt32(appointmentsTable.SelectedRows[0].Cells[0].Value);
        }
    }
}
