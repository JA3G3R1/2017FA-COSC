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
    }
}
