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
    public partial class EventAdminView : Form
    {
        public EventAdminView()
        {
            InitializeComponent();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateEvent openInstance = new CreateEvent();
            openInstance.ShowDialog();
            Environment.Exit(0);
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEvent openInstance = new UpdateEvent();
            openInstance.ShowDialog();
            Environment.Exit(0);
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEvent openInstance = new DeleteEvent();
            openInstance.ShowDialog();
            Environment.Exit(0);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
