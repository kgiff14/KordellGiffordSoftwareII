using KordellGiffordCapstone.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KordellGiffordCapstone
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        ResourceManager rm = new ResourceManager("KordellGiffordSoftwareII.Languages.Messages", typeof(Login).Assembly);
        DataAccess da = new DataAccess();

        #region Calendar Population
        private void MainScreen_Load(object sender, EventArgs e)
        {
            DatePopulation();
            var all = Repo.GetAllCustomers();
            List<string> names = all.Select(x =>  x.customerName).ToList();
            searchCustomer.DataSource = names;
            Repo.customers.Clear();
        }

        public void Display()
        {
            DatePopulation();
        }

        public void AppointmentsDisplay(DateTime time)
        {
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            List<Tuple<int, string, DateTime, DateTime>> apt = Repo.appointments1.Where(x => x.start.Day == time.Day && x.start.Month == time.Month && x.start.Year == time.Year)
                .Select(x => new Tuple<int, string, DateTime, DateTime>(x.appointmentId, x.title, x.start, x.end)).ToList();
            appointmentsTable.DataSource = apt;
            appointmentsTable.Columns[0].HeaderText = "";
            appointmentsTable.Columns[0].Visible = false;
            appointmentsTable.Columns[1].HeaderText = "";
            appointmentsTable.Columns[2].HeaderText = "";
            appointmentsTable.Columns[3].HeaderText = "";
            appointmentsTable.ClearSelection();
        }

        private bool AppointmentMarker(DateTime time)
        {
            //This is a LINQ expression, Applying a lambda expression is a simpler and easy to read syntax.
            return Repo.appointments1.Any(x => x.start.Day == time.Day && x.start.Month == time.Month && x.start.Year == time.Year);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var newDate = dateTimePicker1.Value;
            var newMonth = CultureInfo.InvariantCulture.DateTimeFormat.GetAbbreviatedMonthName(newDate.Month);
            var newYear = newDate.Year.ToString();
            var newDay = newDate.Day.ToString();
            DatePickerPopluation(newMonth, newYear, newDay);
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
            var culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            foreach (DataGridViewRow row in weekCal.Rows)
            {
                foreach (DataGridViewCell data in row.Cells)
                {
                    var date = DateTime.Now;
                    if (!string.IsNullOrEmpty(data.Value.ToString()))
                    {
                        switch (culture)
                        {
                            case "en":
                                date = Convert.ToDateTime(string.Concat(monthLabel.Text, data.Value, ",", yearLabel.Text));
                                break;
                            case "ja":
                                date = Convert.ToDateTime(string.Concat(yearLabel.Text, "年", dateTimePicker1.Value.Month, "月", data.Value, "日"));
                                break;
                        }
                        if (AppointmentMarker(date))
                        {
                            data.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            data.Style.BackColor = Color.White;
                        }
                        if (data.Value == cell)
                        {
                            data.Selected = true;
                        }
                    }
                }
            }
            appointmentsTable.ClearSelection();
        }

        private void calendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = calendar.CurrentRow.Index;
            var cell = calendar.CurrentCell.Value.ToString();
            WeekView(row, cell);
            var date = DateTime.Now;
            var culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (!string.IsNullOrEmpty(cell))
            {
                switch (culture)
                {
                    case "en":
                        date = Convert.ToDateTime(string.Concat(monthLabel.Text, cell, ",", yearLabel.Text));
                        break;
                    case "ja":
                        date = Convert.ToDateTime(string.Concat(yearLabel.Text, "年", dateTimePicker1.Value.Month, "月", cell, "日"));
                        break;
                }
                AppointmentsDisplay(date);
            }
        }
        private void appointmentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Repo.IndexItem = Convert.ToInt32(appointmentsTable.SelectedRows[0].Cells[0].Value);
        }

        private void weekCal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = weekCal.CurrentCell.Value;
            foreach (DataGridViewRow row in calendar.Rows)
            {
                foreach (DataGridViewCell data in row.Cells)
                {
                    if (data.Value == cell)
                    {
                        data.Selected = true;
                        var date = DateTime.Now;
                        var culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
                        if (!string.IsNullOrEmpty(data.Value.ToString()))
                        {
                            switch (culture)
                            {
                                case "en":
                                    date = Convert.ToDateTime(string.Concat(monthLabel.Text, data.Value, ",", yearLabel.Text));
                                    break;
                                case "ja":
                                    date = Convert.ToDateTime(string.Concat(yearLabel.Text, "年", dateTimePicker1.Value.Month, "月", data.Value, "日"));
                                    break;
                            }
                            AppointmentsDisplay(date);
                            return;

                        }
                    }
                }
            }
        }

        private void DatePopulation()
        {
            Repo.IndexItem = -1;
            monthLabel.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Now.Month);
            yearLabel.Text = DateTime.Now.Year.ToString();
            int day = DateTime.Now.Day;
            string month = CultureInfo.InvariantCulture.DateTimeFormat.GetAbbreviatedMonthName(DateTime.Now.Month);
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
                if (Convert.ToDateTime(dateTime.AddDays(i)).DayOfWeek == DayOfWeek.Sunday)
                {
                    dr["Sunday"] = i + 1;
                }
                if (Convert.ToDateTime(dateTime.AddDays(i)).DayOfWeek == DayOfWeek.Monday)
                {
                    dr["Monday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Tuesday)
                {
                    dr["Tuesday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Wednesday)
                {
                    dr["Wednesday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Thursday)
                {
                    dr["Thursday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Friday)
                {
                    dr["Friday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Saturday)
                {
                    dr["Saturday"] = i + 1;
                    dt.Rows.Add(dr);
                    dr = dt.NewRow();
                    continue;
                }
                if (i == DateTime.DaysInMonth(dateTime.Year, dateTime.Month) - 1)
                {
                    dt.Rows.Add(dr);
                    dr = dt.NewRow();

                }
            }

            calendar.DataSource = dt;
            calendar.ClearSelection();
            Repo.Index = -1;
            Repo.GetAppointments();
            int count = 0;
            var date = DateTime.Now;
            var culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            foreach (DataGridViewRow row in calendar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        switch (culture)
                        {
                            case "en":
                                date = Convert.ToDateTime(string.Concat(monthLabel.Text, cell.Value, ",", yearLabel.Text));
                                break;
                            case "ja":
                                //JapaneseCalendar
                                date = Convert.ToDateTime(string.Concat(yearLabel.Text, "年", dateTimePicker1.Value.Month, "月", cell.Value, "日"));
                                break;
                        }
                        if (AppointmentMarker(date))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                        if (cell.Value.ToString() == day.ToString())
                        {
                            cell.Selected = true;
                            WeekView(count, cell.Value);
                            AppointmentsDisplay(date);
                            //return;
                        }
                    }
                }
                count++;
            }
            appointmentsTable.ClearSelection();
        }

        private void DatePickerPopluation(string month, string year, string day)
        {
            Repo.IndexItem = -1;
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
                if (Convert.ToDateTime(dateTime.AddDays(i)).DayOfWeek == DayOfWeek.Sunday)
                {
                    dr["Sunday"] = i + 1;
                }
                if (Convert.ToDateTime(dateTime.AddDays(i)).DayOfWeek == DayOfWeek.Monday)
                {
                    dr["Monday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Tuesday)
                {
                    dr["Tuesday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Wednesday)
                {
                    dr["Wednesday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Thursday)
                {
                    dr["Thursday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Friday)
                {
                    dr["Friday"] = i + 1;
                }
                if (dateTime.AddDays(i).DayOfWeek == DayOfWeek.Saturday)
                {
                    dr["Saturday"] = i + 1;
                    dt.Rows.Add(dr);
                    dr = dt.NewRow();
                    continue;
                }
                if (i == DateTime.DaysInMonth(dateTime.Year, dateTime.Month) - 1)
                {
                    dt.Rows.Add(dr);
                    dr = dt.NewRow();

                }
            }

            calendar.DataSource = dt;
            calendar.ClearSelection();
            Repo.Index = -1;
            Repo.GetAppointments();
            int count = 0;
            var date = DateTime.Now;
            var culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            foreach (DataGridViewRow row in calendar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        switch (culture)
                        {
                            case "en":
                                date = Convert.ToDateTime(string.Concat(monthLabel.Text, cell.Value, ",", yearLabel.Text));
                                break;
                            case "ja":
                                //JapaneseCalendar
                                date = Convert.ToDateTime(string.Concat(yearLabel.Text, "年", dateTimePicker1.Value.Month, "月", cell.Value, "日"));
                                break;
                        }
                        if (AppointmentMarker(date))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                        if (cell.Value.ToString() == day.ToString())
                        {
                            cell.Selected = true;
                            WeekView(count, cell.Value);
                            AppointmentsDisplay(date);
                            //return;
                        }
                    }
                }
                count++;
            }
            appointmentsTable.ClearSelection();
        }
        #endregion

        #region Btns

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.SetInactive();
            Application.Exit();
        }
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
                CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                MessageBox.Show(rm.GetString("no apt", ci));
                ci.ClearCachedData();
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
                    CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                    MessageBox.Show(rm.GetString("no apt", ci));
                    ci.ClearCachedData();
                }
                else
                {
                    CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                    DialogResult dialogResult = MessageBox.Show(rm.GetString("confirm delete", ci), rm.GetString("confirm", ci), MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Repo.DeleteAppointment(Repo.IndexItem))
                        {
                            MessageBox.Show(rm.GetString("apt deleted", ci));
                        }
                        else
                        {
                            MessageBox.Show(rm.GetString("apt not deleted", ci));
                        }
                    }
                    this.Display();
                    ci.ClearCachedData();
                }
            }
            catch (Exception)
            {
                CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                MessageBox.Show(rm.GetString("apt not deleted", ci));
                ci.ClearCachedData();
            }
        }
        #endregion

        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);

                appointmentsLabel.Text = rm.GetString("appointment", ci);
                customerRecords.Text = rm.GetString("customers", ci);
                this.Text = rm.GetString("main screen", ci);
                reportsBtn.Text = rm.GetString("reports", ci);
                addAppBtn.Text = rm.GetString("add apoint", ci);
                updateAptBtn.Text = rm.GetString("update appoint", ci);
                deleteAptBtn.Text = rm.GetString("delete appoint", ci);
                exitBtn.Text = rm.GetString("close", ci);
                weekLabel.Text = rm.GetString("week view", ci);
                calendar.Columns[0].HeaderText = rm.GetString("sunday", ci);
                calendar.Columns[1].HeaderText = rm.GetString("monday", ci);
                calendar.Columns[2].HeaderText = rm.GetString("tuesday", ci);
                calendar.Columns[3].HeaderText = rm.GetString("wednesday", ci);
                calendar.Columns[4].HeaderText = rm.GetString("thursday", ci);
                calendar.Columns[5].HeaderText = rm.GetString("friday", ci);
                calendar.Columns[6].HeaderText = rm.GetString("saturday", ci);
                weekCal.Columns[0].HeaderText = rm.GetString("sunday", ci);
                weekCal.Columns[1].HeaderText = rm.GetString("monday", ci);
                weekCal.Columns[2].HeaderText = rm.GetString("tuesday", ci);
                weekCal.Columns[3].HeaderText = rm.GetString("wednesday", ci);
                weekCal.Columns[4].HeaderText = rm.GetString("thursday", ci);
                weekCal.Columns[5].HeaderText = rm.GetString("friday", ci);
                weekCal.Columns[6].HeaderText = rm.GetString("saturday", ci);
                appointmentsTable.Columns[1].HeaderText = rm.GetString("apt title", ci);
                appointmentsTable.Columns[2].HeaderText = rm.GetString("start time", ci);
                appointmentsTable.Columns[3].HeaderText = rm.GetString("end time", ci);
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Repo repo = new Repo();
                //Grab all the customers and put it into a generic list.
                var all = Repo.GetAllCustomers();
                Customers customerSearch = all.Where(x => x.customerName == searchCustomer.Text).First();
                if (repo.SearchDataByCustomer(customerSearch))
                {
                    List<Tuple<int, string, DateTime, DateTime>> apt = Repo.appointmentsSearch.Select(x => 
                        new Tuple<int, string, DateTime, DateTime>(x.appointmentId, x.title, x.start, x.end)).ToList();
                    if (apt.Count == 0)
                    {
                        MessageBox.Show("There are no appointments for this customer.");
                    }
                    else
                    {
                        appointmentsTable.DataSource = apt;
                        appointmentsTable.Columns[0].HeaderText = "";
                        appointmentsTable.Columns[0].Visible = false;
                        appointmentsTable.Columns[1].HeaderText = "";
                        appointmentsTable.Columns[2].HeaderText = "";
                        appointmentsTable.Columns[3].HeaderText = "";
                        appointmentsTable.ClearSelection();
                        Repo.customers.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Unable to retrieve appointments.");
                }
            }
            catch
            {
                MessageBox.Show("Entered value is not valid.");
            }
        }
    }
}
