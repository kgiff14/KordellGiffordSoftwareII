using KordellGiffordSoftwareII.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Globalization;
using System.Resources;

namespace KordellGiffordSoftwareII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("KordellGiffordSoftwareII.Languages.Messages", typeof(Login).Assembly);
            string username = usernameText.Text;
            string password = passwordText.Text;

            if (da.Select($"SELECT * FROM user WHERE userName='{username}';"))
            {
                if (da.Select($"SELECT * FROM user WHERE userName='{username}' AND password='{password}';"))
                {
                    this.Hide();
                    da.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand($"SELECT userId, userName FROM user WHERE userName = '{username}' AND password = '{password}';", da.connectionS());
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Repo.uId = new Tuple<int, string>(Convert.ToInt32(rdr["userId"]), rdr["userName"].ToString());
                        }
                    }
                    da.CloseConnection();
                    LogUserActivity();
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Show();
                    CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                    MessageBox.Show(rm.GetString("welcome", ci) + $"{username}!");
                    ci.ClearCachedData();
                }
                else
                {
                    CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                    MessageBox.Show(rm.GetString("no match", ci));
                    ci.ClearCachedData();

                }
            }
            else
            {
                CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
                MessageBox.Show(rm.GetString("no username", ci));
                ci.ClearCachedData();
            }
        }

        private void LogUserActivity()
        {
            //text file update
            try
            {
                string filePath = $@"c:\temp\{Repo.uId.Item2}.txt";

                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine($"{Repo.uId.Item2} - Activity Log.");
                        sw.WriteLine($"{DateTime.Now}.");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine($"{DateTime.Now}.");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(CultureInfo.CurrentCulture.TwoLetterISOLanguageName);

            ResourceManager rm = new ResourceManager("KordellGiffordSoftwareII.Languages.Messages", typeof(Login).Assembly);
            usernameLabel.Text = rm.GetString("username", ci);
            passwordLabel.Text = rm.GetString("password", ci);
            this.Text = rm.GetString("login", ci);
            loginBtn.Text = rm.GetString("login", ci);
            cancelBtn.Text = rm.GetString("cancel", ci);
            mainLabel.Text = rm.GetString("alatries", ci);
            ci.ClearCachedData();
        }
    }
}
