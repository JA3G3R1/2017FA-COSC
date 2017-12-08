using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace EventsSchedulerUI
{
    public partial class AdminAuthenticator : Form
    {
        public AdminAuthenticator()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParticpantView openInstance = new ParticpantView();
            openInstance.ShowDialog();
            Environment.Exit(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool tryAgain = true;
            string password = "nullpointer"; // sets the password for the login.
            if (txtpw.Text == password) // verifies the password.
            {
                this.Hide();
                EventAdminView openInstance = new EventAdminView();
                openInstance.ShowDialog();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Wrong, Please Try Again"); // allows the user to try again. 
                txtpw.Text = "";

            }
        }
    }
}
