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
    public partial class ModifyCustomer : Form
    {
        public ModifyCustomer()
        {
            InitializeComponent();
        }

        private void canceBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }
    }
}
