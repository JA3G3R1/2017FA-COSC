using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary;

namespace EventsSchedulerUI
{
    public partial class ParticpantView : Form
    {
        Participant P = new Participant();
        public ParticpantView()
        {
            InitializeComponent();
            cmb2.Items.Add(P.FirstName);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAuthenticator openInstance = new AdminAuthenticator();
            Environment.Exit(0);
        }
    }
}
