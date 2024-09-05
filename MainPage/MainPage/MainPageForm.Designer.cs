namespace MainPage
{
    partial class MainPageForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.loginInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dontHaveAccountLabel = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(81, 74);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(326, 67);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to BookSmart !";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(377, 11);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(90, 25);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // loginInButton
            // 
            this.loginInButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginInButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInButton.Location = new System.Drawing.Point(143, 240);
            this.loginInButton.Name = "loginInButton";
            this.loginInButton.Size = new System.Drawing.Size(207, 42);
            this.loginInButton.TabIndex = 2;
            this.loginInButton.Text = "Log In";
            this.loginInButton.UseVisualStyleBackColor = false;
            this.loginInButton.Click += new System.EventHandler(this.loginInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.signUpButton.Location = new System.Drawing.Point(280, 406);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(62, 23);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(26, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(112, 195);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(295, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.AcceptsReturn = true;
            this.emailTextBox.Location = new System.Drawing.Point(112, 158);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(295, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(26, 158);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 15);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email:";
            // 
            // dontHaveAccountLabel
            // 
            this.dontHaveAccountLabel.AutoSize = true;
            this.dontHaveAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.dontHaveAccountLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.dontHaveAccountLabel.ForeColor = System.Drawing.Color.White;
            this.dontHaveAccountLabel.Location = new System.Drawing.Point(151, 410);
            this.dontHaveAccountLabel.Name = "dontHaveAccountLabel";
            this.dontHaveAccountLabel.Size = new System.Drawing.Size(126, 15);
            this.dontHaveAccountLabel.TabIndex = 14;
            this.dontHaveAccountLabel.Text = "Don\'t have an account?";
            // 
            // hideButton
            // 
            this.hideButton.BackgroundImage = global::MainPage.Properties.Resources.hidePassword;
            this.hideButton.Location = new System.Drawing.Point(411, 191);
            this.hideButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(40, 26);
            this.hideButton.TabIndex = 15;
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackgroundImage = global::MainPage.Properties.Resources.showPassword;
            this.showButton.Location = new System.Drawing.Point(411, 191);
            this.showButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(40, 26);
            this.showButton.TabIndex = 16;
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainPage.Properties.Resources.hotelImage;
            this.ClientSize = new System.Drawing.Size(477, 440);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.dontHaveAccountLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginInButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "MainPageForm";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button loginInButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dontHaveAccountLabel;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button showButton;
        public System.Windows.Forms.TextBox emailTextBox;
    }
}

