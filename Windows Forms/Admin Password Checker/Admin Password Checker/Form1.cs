using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Password_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool tryAgain = true;
            string password = "nullpointer"; // sets the password for the login.
            if(txtpw.Text == password) // verifies the password.
            {
                Process.Start(@"D:\Documents\Class Notes\COSC-1320\Group Project\uiDraft1\uiDraft1\bin\Debug\uiDraft1.exe"); // opens the admin view for the event scheduler.
                Application.Exit(); // closes old window.
            }
            else
            {
                MessageBox.Show("Wrong, Please Try Again"); // allows the user to try again. 
                txtpw.Text = "";
                
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Process.Start(@"");// this will launch the continue as participant option.
        }
    }
}
