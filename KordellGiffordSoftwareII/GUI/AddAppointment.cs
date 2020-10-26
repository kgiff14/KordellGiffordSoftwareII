﻿using KordellGiffordSoftwareII.Controller;
using MySql.Data.MySqlClient;
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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
            AllowSave();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public List<Tuple<int, string>> customers = new List<Tuple<int, string>>();

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            da.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName FROM customer;", da.connectionS());
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    customers.Add(new Tuple<int,string>(Convert.ToInt32(rdr["customerId"]),rdr["customerName"].ToString()));
                }
            }
            //lambda
            customerIn.DataSource = customers.Select(x => x.Item2).ToList();
            da.CloseConnection();
            List<string> types = new List<string>
            {
                "Consulting",
                "Brief",
                "Review",
                "Other"
            };
            typeIn.DataSource = types;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var startTime = startDate.Value.Date + this.startTime.Value.TimeOfDay;
            var endTime = endDate.Value.Date + this.endTime.Value.TimeOfDay;
            //lambda
            bool overlap = Repo.appointments1.Any(x => startTime.ToUniversalTime() < x.end && endTime.ToUniversalTime() > x.start);
            TimeSpan start = new TimeSpan(17, 0, 0);
            TimeSpan end = new TimeSpan(8, 0, 0);
            if (endDate.Value.Date.DayOfWeek == DayOfWeek.Sunday || endDate.Value.Date.DayOfWeek == DayOfWeek.Saturday ||
                startDate.Value.Date.DayOfWeek == DayOfWeek.Sunday || startDate.Value.Date.DayOfWeek == DayOfWeek.Saturday ||
                this.startTime.Value.TimeOfDay < end && this.startTime.Value.TimeOfDay > start ||
                this.endTime.Value.TimeOfDay < end && this.endTime.Value.TimeOfDay > start ||
                this.startTime.Value.TimeOfDay > this.endTime.Value.TimeOfDay)
            {
                MessageBox.Show("The appointment does not fall into Business hours. (M-F 8-5)");
            }
            else if (overlap)
            {
                MessageBox.Show("An appointment is already scheduled for this time.");
            }
            else
            {
                var tempId = 0;
                var title = titleIn.Text;
                var location = locationIn.Text;
                var description = descriptionIn.Text;
                //lambda
                int customer = customers.Where(x => x.Item2 == customerIn.Text).Select(x => x.Item1).First();
                var contact = contactIn.Text;
                var url = urlIn.Text;
                var type = typeIn.Text;

                Appointments add = new Appointments(tempId, customer, Repo.uId.Item1, title, description, location, contact, type, url, startTime.ToUniversalTime(), endTime.ToUniversalTime());

                if (Repo.AddAppointment(add))
                {
                    this.Close();
                    MainScreen mainScreen = new MainScreen();
                    MessageBox.Show("Appointment has been created.");
                    mainScreen.Display();
                }
                else
                {
                    MessageBox.Show("Unable to create appointment.");
                }
            }
        }

        private void titleIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleIn.Text))
            {
                titleIn.BackColor = Color.Salmon;
            }
            else
            {
                titleIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (startDate.Value.Date.DayOfWeek == DayOfWeek.Sunday || startDate.Value.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                startDate.CalendarTitleBackColor = Color.Salmon;
            }
            else
            {
                startDate.CalendarTitleBackColor = Color.White;
            }
            AllowSave();
        }

        private void startTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan start = new TimeSpan(17, 0, 0);
            TimeSpan end = new TimeSpan(8, 0, 0);
            if (startTime.Value.TimeOfDay < end && startTime.Value.TimeOfDay > start)
            {
                startTime.CalendarTitleBackColor = Color.White;
            }
            else
            {
                startTime.CalendarTitleBackColor = Color.Salmon;
            }
            AllowSave();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (endDate.Value.Date.DayOfWeek == DayOfWeek.Sunday || endDate.Value.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                endDate.CalendarTitleBackColor = Color.Salmon;
            }
            else
            {
                endDate.CalendarTitleBackColor = Color.White;
            }
            AllowSave();
        }

        private void endTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan start = new TimeSpan(17, 0, 0);
            TimeSpan end = new TimeSpan(8, 0, 0);
            if (endTime.Value.TimeOfDay < end && endTime.Value.TimeOfDay > start)
            {
                endTime.CalendarTitleBackColor = Color.White;
            }
            else
            {
                endTime.CalendarTitleBackColor = Color.Salmon;
            }
            AllowSave();
        }

        private void locationIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(locationIn.Text))
            {
                locationIn.BackColor = Color.Salmon;
            }
            else
            {
                locationIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void descriptionIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriptionIn.Text))
            {
                descriptionIn.BackColor = Color.Salmon;
            }
            else
            {
                descriptionIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void customerIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerIn.Text))
            {
                customerIn.BackColor = Color.Salmon;
            }
            else
            {
                customerIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void contactIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contactIn.Text))
            {
                contactIn.BackColor = Color.Salmon;
            }
            else
            {
                contactIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void urlIn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(urlIn.Text))
            {
                urlIn.BackColor = Color.Salmon;
            }
            else
            {
                urlIn.BackColor = Color.White;
            }
            AllowSave();
        }

        private void AllowSave()
        {
            if (titleIn.BackColor == Color.White && urlIn.BackColor == Color.White && descriptionIn.BackColor == Color.White &&
                typeIn.BackColor == Color.White && contactIn.BackColor == Color.White && customerIn.BackColor == Color.White 
                && locationIn.BackColor == Color.White)
            {
                saveBtn.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
            }
        }

        private void typeIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(typeIn.Text))
            {
                typeIn.BackColor = Color.Salmon;
            }
            else
            {
                typeIn.BackColor = Color.White;
            }
            AllowSave();
        }
    }
}
