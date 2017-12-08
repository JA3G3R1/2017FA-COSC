using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsSchedulerUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Opens the admin authenticator and has the admin sign in.
            // Also closes the previous windows form.
            // - MW
            this.Hide();
            AdminAuthenticator openInstance = new AdminAuthenticator();
            openInstance.ShowDialog();
            Environment.Exit(0);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParticpantView openInstance = new ParticpantView();
            openInstance.ShowDialog();
            Environment.Exit(0);
        }
    }
}
