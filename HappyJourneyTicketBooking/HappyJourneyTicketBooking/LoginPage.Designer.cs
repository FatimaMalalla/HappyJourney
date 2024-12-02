namespace HappyJourneyTicketBooking
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pasword_Label = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.registerAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Happy Journey";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.Location = new System.Drawing.Point(113, 88);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(130, 18);
            this.Username_Label.TabIndex = 1;
            this.Username_Label.Text = "Username/ Email :";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(93, 109);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(172, 20);
            this.UsernameInput.TabIndex = 2;
            this.UsernameInput.TextChanged += new System.EventHandler(this.UsernameInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // Pasword_Label
            // 
            this.Pasword_Label.AutoSize = true;
            this.Pasword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Pasword_Label.Location = new System.Drawing.Point(145, 153);
            this.Pasword_Label.Name = "Pasword_Label";
            this.Pasword_Label.Size = new System.Drawing.Size(69, 17);
            this.Pasword_Label.TabIndex = 4;
            this.Pasword_Label.Text = "Password";
            this.Pasword_Label.Click += new System.EventHandler(this.label4_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(93, 173);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(172, 20);
            this.PasswordInput.TabIndex = 5;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(132, 199);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(190, 266);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 30);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(93, 266);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 30);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // registerAccount
            // 
            this.registerAccount.AutoSize = true;
            this.registerAccount.LinkColor = System.Drawing.Color.DarkCyan;
            this.registerAccount.Location = new System.Drawing.Point(113, 299);
            this.registerAccount.Name = "registerAccount";
            this.registerAccount.Size = new System.Drawing.Size(148, 13);
            this.registerAccount.TabIndex = 9;
            this.registerAccount.TabStop = true;
            this.registerAccount.Text = "Create New Traveler Account";
            this.registerAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 397);
            this.Controls.Add(this.registerAccount);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.Pasword_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Pasword_Label;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.LinkLabel registerAccount;
    }
}

