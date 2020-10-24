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
    }
}
