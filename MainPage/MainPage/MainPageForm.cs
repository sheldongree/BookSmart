using HelpPage;
using HotelFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MainPage
{
    public partial class MainPageForm : Form
    {
        // Connection string for SQLite database
        private const string ConnectionString = "Data Source=client.db;Version=3;";

        public MainPageForm()
        {
            InitializeComponent();
        }

        private void loginInButton_Click(object sender, EventArgs e)
        {
            // Regular expression for email validation
            string emailPattern = @"^[a-zA-Z0-9]([a-zA-Z0-9._-]{2,15})?@[a-zA-Z]([a-zA-Z.]{0,22}[a-zA-Z])\.(com|ca)$";

            // Get email and password from user input
            string enteredEmail = emailTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            // Validate email using regular expression
            if (!System.Text.RegularExpressions.Regex.IsMatch(enteredEmail, emailPattern))
            {
                MessageBox.Show("Invalid email address");
                return;
            }

            // Check if the client exists with the given email and password
            bool isValidCredentials = ValidateCredentials(enteredEmail, enteredPassword);

            if (isValidCredentials)
            {
                // Successful login, open the WhereToForm or perform other actions
                WhereToForm whereToForm = new WhereToForm();
                whereToForm.ShowDialog();
            }
            else
            {
                // Invalid credentials, show an error message
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private bool ValidateCredentials(string enteredEmail, string enteredPassword)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Query to check if user with given email and password exists
                string selectQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password;";
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@Email", enteredEmail);
                    selectCommand.Parameters.AddWithValue("@Password", enteredPassword);

                    // Get the count of users with matching credentials
                    int userCount = Convert.ToInt32(selectCommand.ExecuteScalar());

                    // Return true if a user with matching credentials exists, otherwise false
                    return userCount > 0;
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // Open the HelpPageForm
            HelpPageForm help = new HelpPageForm();
            help.ShowDialog();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Open the SignUpForm
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            // Show the password characters
            if (passwordTextBox.PasswordChar == '●')
            {
                hideButton.BringToFront();
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            // Hide the password characters
            if (passwordTextBox.PasswordChar == '\0')
            {
                showButton.BringToFront();
                passwordTextBox.PasswordChar = '●';
            }
        }
    }
}

