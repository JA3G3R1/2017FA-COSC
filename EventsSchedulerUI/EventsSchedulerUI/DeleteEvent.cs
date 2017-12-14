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
    public partial class DeleteEvent : Form
    {
        EventInfo EI = new EventInfo(" ", " ", " ");
        public DeleteEvent()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(EI.ReadAllEventTitle().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EI.DeleteEventData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventAdminView openInstance = new EventAdminView();
            openInstance.ShowDialog();
            Environment.Exit(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
