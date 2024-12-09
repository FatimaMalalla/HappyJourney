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
    public partial class TravellerProfile : Form
    {
        public TravellerProfile()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            new TravellerHome().Show(); 
            this.Close();


        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            this.Refresh(); 

        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
          
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void TravellerProfile_Load(object sender, EventArgs e)
        {

        }

        private void Home_Button_Click_1(object sender, EventArgs e)
        {

        }
    }
}
