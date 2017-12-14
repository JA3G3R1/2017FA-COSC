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
        Event E = new Event();
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventAdminView openinstance = new EventAdminView();
            openinstance.ShowDialog();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EI.Title = textBox3.Text;
            EI.Location = textBox2.Text;
            EI.Description = textBox1.Text;
            EI.Capacity = Convert.ToInt32(this.txtCapacity.Text);
            EI.AddEventData();
            this.Hide();
            EventAdminView openinstance = new EventAdminView();
            openinstance.ShowDialog();
            Environment.Exit(0);
        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
