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
        Event E = new Event();
        EventInfo EI = new EventInfo();
        public ParticpantView()
        {
            InitializeComponent();
            P.ReadData();
            cmb2.Items.AddRange(P.ReadAllFirstLastNames().ToArray());
            comboBox1.Items.AddRange(EI.ReadAllEventTitle().ToArray());

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
