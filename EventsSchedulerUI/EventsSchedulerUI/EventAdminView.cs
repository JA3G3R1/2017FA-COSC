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
        {
            string[] row1 = new string[] { "", "", "", "", "", "See The New Star Wars", "" };
            dataGridView.Rows.Add(row1);

            string[] row2 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row2);

            string[] row3 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row3);

            string[] row4 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row4);

            string[] row5 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row5);

            string[] row6 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row6);

            string[] row7 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row7);

            string[] row8 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row8);

            string[] row9 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row9);

            string[] row10 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row10);

            string[] row11 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row11);

            string[] row12 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row12);

            string[] row13 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row13);

            string[] row14 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row14);

            string[] row15 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row15);

            string[] row16 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row16);

            string[] row17 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row17);

            string[] row18 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row18);

            string[] row19 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row19);

            string[] row20 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row20);

            string[] row21 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row21);

            string[] row22 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row22);

            string[] row23 = new string[] { "", "", "", "", "", "", "" };
            dataGridView.Rows.Add(row23);

            string[] row24 = new string[] { "", "", "", "", "", "", "" };
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
