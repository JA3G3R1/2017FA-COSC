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
    public partial class CreateEvent : Form
    {
        EventInfo EI = new EventInfo(" "," "," ");
        public CreateEvent()
        {
            InitializeComponent();
            EI.Title = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventAdminView openinstance = new EventAdminView();
            openinstance.ShowDialog();
            Environment.Exit(0);
        }
    }
}
