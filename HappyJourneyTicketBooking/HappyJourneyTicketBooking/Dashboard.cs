using System;
using System.Windows.Forms;

namespace HappyJourneyTicketBooking
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }





        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Refresh();

        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            new Profile().Show();
            this.Close();
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Close();
        }
    }
}
