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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
             
                // Get username and password from inputs
                string username = UsernameInput.Text;
                string password = PasswordInput.Text;

                // Validate inputs
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error");
                    return;
                }

                // Add your authentication logic here
                if (username == "admin" && password == "password123") // Example only
                {
                    MessageBox.Show("Login successful.", "Welcome");

                    // Open the Dashboard and close the Login form
                    TravellerHome dashboard = new TravellerHome();
                    this.Hide(); // Hide the current form (Login)
                    dashboard.ShowDialog(); // Show the Dashboard as a modal window
                    this.Close(); // Close the Login form after the Dashboard is closed
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error");
                }
            }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterPage().Show();
            this.Hide();
               
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
             
        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            PasswordInput.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }

        private void Username_Label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
