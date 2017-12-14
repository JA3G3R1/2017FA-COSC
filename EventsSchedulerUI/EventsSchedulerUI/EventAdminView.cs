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
        
        private void EventAdminView_Load(object sender, EventArgs e)
                                       // Sun, Mon, Tues, Wed, Thur, Fri, Sat
        {
            string[] row1 = new string[] { "", "", "", "", "", "See The New Star Wars", "" }; // 12 AM
            dataGridView.Rows.Add(row1);

            string[] row2 = new string[] { "", "", "", "", "", "", "" }; // 1 AM
            dataGridView.Rows.Add(row2);

            string[] row3 = new string[] { "", "", "", "", "", "", "" }; // 2 AM
            dataGridView.Rows.Add(row3);

            string[] row4 = new string[] { "", "", "", "", "", "", "" }; // 3 AM
            dataGridView.Rows.Add(row4);

            string[] row5 = new string[] { "", "", "", "", "", "", "" }; // 4 AM
            dataGridView.Rows.Add(row5);

            string[] row6 = new string[] { "", "", "", "", "", "", "" }; // 5 AM
            dataGridView.Rows.Add(row6);

            string[] row7 = new string[] { "", "", "", "", "", "", "" }; // 6 AM
            dataGridView.Rows.Add(row7);

            string[] row8 = new string[] { "", "", "", "", "", "", "" }; // 7 AM
            dataGridView.Rows.Add(row8);

            string[] row9 = new string[] { "", "Biology", "", "Biology", "", "", "" }; // 8 AM
            dataGridView.Rows.Add(row9);

            string[] row10 = new string[] { "", "Biology", "", "Biology", "", "", "" }; // 9 AM
            dataGridView.Rows.Add(row10);

            string[] row11 = new string[] { "", "", "", "", "", "", "" }; // 10 AM
            dataGridView.Rows.Add(row11);

            string[] row12 = new string[] { "", "", "", "", "", "", "" }; // 11 AM
            dataGridView.Rows.Add(row12);

            string[] row13 = new string[] { "Cry As I Watch The Dallas Cowboys Lose", "", "Go To C Programming Even Though It's C#", "", "Go To C Programming Even Though It's C#", "", "" }; // 12 PM
            dataGridView.Rows.Add(row13);

            string[] row14 = new string[] { "Cry As I Watch The Dallas Cowboys Lose", "", "Go To C Programming Even Though It's C#", "", "Go To C Programming Even Though It's C#", "", "" }; // 1 PM
            dataGridView.Rows.Add(row14);

            string[] row15 = new string[] { "Cry As I Watch The Dallas Cowboys Lose", "", "Go To C Programming Even Though It's C#", "", "Go To C Programming Even Though It's C#", "", "" }; // 2 PM
            dataGridView.Rows.Add(row15);

            string[] row16 = new string[] { "Cry As I Watch The Dallas Cowboys Lose", "", "", "", "", "", "" }; // 3 PM
            dataGridView.Rows.Add(row16);

            string[] row17 = new string[] { "", "", "", "", "", "", "" }; // 4 PM
            dataGridView.Rows.Add(row17);

            string[] row18 = new string[] { "", "", "", "", "", "", "" }; // 5 PM
            dataGridView.Rows.Add(row18);

            string[] row19 = new string[] { "", "", "", "", "", "", "" }; // 6 PM
            dataGridView.Rows.Add(row19);

            string[] row20 = new string[] { "", "", "", "", "", "", "Annual Meeting For World Domination" }; // 7 PM
            dataGridView.Rows.Add(row20);

            string[] row21 = new string[] { "", "", "", "", "", "", "" }; // 8 PM
            dataGridView.Rows.Add(row21);

            string[] row22 = new string[] { "", "", "", "", "", "", "" }; // 9 PM
            dataGridView.Rows.Add(row22);

            string[] row23 = new string[] { "", "", "", "", "", "", "" }; // 10 PM
            dataGridView.Rows.Add(row23);

            string[] row24 = new string[] { "", "", "", "", "", "", "" }; // 11 PM
            dataGridView.Rows.Add(row24);



            //this.dataGridView1.Rows.Add("five", "six", "seven", "eight");

            //this.dataGridView1.Rows.Insert(0, "one", "two", "three", "four");
            //this.dataGridView1.Rows.Insert(0, "one", "two", "three", "four");

            int rowNumber = 12;
            string ampm = "AM";
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (rowNumber == 13)
                {
                    rowNumber = 1;
                }

                if (row.IsNewRow) continue;

                row.HeaderCell.Value = rowNumber + ampm;
                rowNumber = rowNumber + 1;

                if (rowNumber == 12)
                {
                    if (ampm == "AM")
                    {
                        ampm = "PM";
                    }
                    else if (ampm == "PM")
                    {
                        ampm = "AM";
                    }
                }
            }
            dataGridView.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
