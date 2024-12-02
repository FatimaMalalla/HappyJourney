using System.Drawing;
using System.Windows.Forms;
using System;

namespace HappyJourneyTicketBooking
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.SettingButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Home_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookFlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(0, 0);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(75, 23);
            this.SettingButton.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 0;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(0, 0);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(75, 23);
            this.ProfileButton.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(0, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.Transparent;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.Location = new System.Drawing.Point(12, 70);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(42, 38);
            this.Home_Button.TabIndex = 0;
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings_Button.Image = ((System.Drawing.Image)(resources.GetObject("Settings_Button.Image")));
            this.Settings_Button.Location = new System.Drawing.Point(12, 158);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(42, 38);
            this.Settings_Button.TabIndex = 1;
            this.Settings_Button.UseVisualStyleBackColor = false;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Profile_Button
            // 
            this.Profile_Button.BackColor = System.Drawing.Color.Transparent;
            this.Profile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Profile_Button.Image = ((System.Drawing.Image)(resources.GetObject("Profile_Button.Image")));
            this.Profile_Button.Location = new System.Drawing.Point(12, 114);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(42, 38);
            this.Profile_Button.TabIndex = 2;
            this.Profile_Button.UseVisualStyleBackColor = false;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(12, 393);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(42, 38);
            this.Logout.TabIndex = 3;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Happy Journey Booking";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(74, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 357);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(302, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 170);
            this.panel3.TabIndex = 6;
            // 
            // BookFlight
            // 
            this.BookFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookFlight.Location = new System.Drawing.Point(302, 269);
            this.BookFlight.Name = "BookFlight";
            this.BookFlight.Size = new System.Drawing.Size(115, 34);
            this.BookFlight.TabIndex = 7;
            this.BookFlight.Text = "Book Flight";
            this.BookFlight.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(709, 443);
            this.Controls.Add(this.BookFlight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Profile_Button);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.Home_Button);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Button Home_Button;
        private Button Settings_Button;
        private Button Profile_Button;
        private Button Logout;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button BookFlight;
    }
}