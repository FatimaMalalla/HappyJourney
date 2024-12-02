namespace HappyJourneyTicketBooking
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Logout = new System.Windows.Forms.Button();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Home_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(13, 391);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(42, 38);
            this.Logout.TabIndex = 19;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Profile_Button
            // 
            this.Profile_Button.BackColor = System.Drawing.Color.Transparent;
            this.Profile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Profile_Button.Image = ((System.Drawing.Image)(resources.GetObject("Profile_Button.Image")));
            this.Profile_Button.Location = new System.Drawing.Point(13, 112);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(42, 38);
            this.Profile_Button.TabIndex = 18;
            this.Profile_Button.UseVisualStyleBackColor = false;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings_Button.Image = ((System.Drawing.Image)(resources.GetObject("Settings_Button.Image")));
            this.Settings_Button.Location = new System.Drawing.Point(13, 156);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(42, 38);
            this.Settings_Button.TabIndex = 17;
            this.Settings_Button.UseVisualStyleBackColor = false;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.Transparent;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.Location = new System.Drawing.Point(13, 68);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(42, 38);
            this.Home_Button.TabIndex = 16;
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Profile_Button);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.Home_Button);
            this.Name = "Settings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Profile_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button Home_Button;
        private System.Windows.Forms.Label label2;
    }
}