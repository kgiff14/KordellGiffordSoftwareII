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
            string username = usernameText.Text;
            string password = passwordText.Text;

            if (da.Select($"SELECT * FROM user WHERE userName='{username}';"))
            {
                if (da.Select($"SELECT * FROM user WHERE userName='{username}' AND password='{password}';"))
                {
                    this.Hide();
                    da.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("SELECT userId, userName FROM user;", da.connectionS());
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
                    MessageBox.Show($"Welcome back {username}!");
                }
                else
                {
                    MessageBox.Show("Password does not match the Username.");

                }
            }
            else
            {
                MessageBox.Show("Username does not exist.");
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
    }
}
