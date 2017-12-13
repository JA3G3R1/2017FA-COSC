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
    public partial class UpdateEvent : Form
    {
        //reading all the events 
        EventInfo EI = new EventInfo(" ", " ", " ");
        public UpdateEvent()
        {
            InitializeComponent();
            cmbEventList.Items.AddRange(EI.ReadAllEventTitle().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // WHen the user clicks the edit button, 
            // these button should delete the evenet they selected and take them to the login screen 
            // where they can create a new event to replace it.
            // Should also load the previous values from the event they are editing.
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventAdminView openinstance = new EventAdminView(); // allows the end user to go back. 
            openinstance.ShowDialog();
            Environment.Exit(0);
        }

        private void cmbEventList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
