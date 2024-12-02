using HappyJourneyTicketBooking.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyJourneyTicketBooking
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            new Dashboard().Show(); 
            this.Close();


        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            this.Refresh(); 

        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            new Settings().Show();  
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
