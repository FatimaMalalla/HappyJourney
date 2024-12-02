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
    public partial class Settings : Form
    {
        public Settings()
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
            new Profile().Show();   
            this.Close();
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            this.Refresh();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
