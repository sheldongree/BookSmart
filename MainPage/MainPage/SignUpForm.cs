using HotelFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage
{
    public partial class SignUpForm : Form
    {
        private const string ConnectionString = "Data Source=client.db;Version=3;";

        // Regular expressions for validation
        string namePattern = @"^[A-Z][a-zA-Z-]{1,}$";
        string passwordPattern = @"^(?=.*[A-Z])(?=.*\d.*\d)[A-Za-z0-9!]{6,18}$";
        string emailPattern = @"^[a-zA-Z0-9]([a-zA-Z0-9._-]{2,15})?@[a-zA-Z]([a-zA-Z.]{0,22}[a-zA-Z])\.(com|ca)$";
        string agePattern = @"^(1[89]|[2-9]\d|\d{3,})$";
        string phonePattern = @"^\d{3}-\d{3}-\d{4}$";

        public SignUpForm()
        {
            InitializeComponent();
        }

        // Handle user registration
        private void confirmButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Create Users table if it doesn't exist
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Users (Email TEXT PRIMARY KEY, FirstName TEXT, LastName TEXT, Age INTEGER, Phone TEXT, Password TEXT, Address TEXT);";
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                string newEmail = emailTextBox.Text;

                // Check if the email already exists
                string checkEmailQuery = $"SELECT COUNT(*) FROM Users WHERE Email = '{newEmail}';";
                using (SQLiteCommand checkEmailCommand = new SQLiteCommand(checkEmailQuery, connection))
                {
                    int emailCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

                    if (emailCount > 0)
                    {
                        MessageBox.Show("An account with this email already exists. Please log in.");
                        return;
                    }
                }

                // Validate user input
                bool isFirstNameValid = Regex.IsMatch(firstNameTextBox.Text, namePattern);
                if (!isFirstNameValid)
                {
                    MessageBox.Show("Invalid first name. Please ensure the first name starts with an uppercase letter, contains only letters, and may include dashes (-).");
                    firstNameTextBox.Clear();
                }

                bool isLastNameValid = Regex.IsMatch(lastNameTextBox.Text, namePattern);
                if (!isLastNameValid)
                {
                    MessageBox.Show("Invalid last name. Please ensure the last name starts with an uppercase letter, contains only letters, and may include dashes (-).");
                    lastNameTextBox.Clear();
                }

                bool isEmailValid = Regex.IsMatch(emailTextBox.Text, emailPattern);
                if (!isEmailValid)
                {
                    MessageBox.Show("Invalid email address. Please ensure the email follows the format username@domain.com/ca and complies with the specified restrictions.");
                    emailTextBox.Clear();
                }

                bool isAgeValid = Regex.IsMatch(ageTextBox.Text, agePattern);
                if (!isAgeValid)
                {
                    MessageBox.Show("Invalid age. You must be 18 or older.");
                    ageTextBox.Clear();
                }

                bool isPhoneValid = Regex.IsMatch(phoneNumbertextBox.Text, phonePattern);
                if (!isPhoneValid)
                {
                    MessageBox.Show("Invalid phone number. Please ensure the phone number follows the format ###-###-####.");
                    phoneNumbertextBox.Clear();
                }

                bool isPasswordValid = Regex.IsMatch(passwordTextBox.Text, passwordPattern);
                if (!isPasswordValid)
                {
                    MessageBox.Show("Invalid password. Please ensure the password meets the specified requirements.");
                    passwordTextBox.Clear();
                }

                bool isConfirmationPasswordValid = confirmationPasswordTextBox.Text.Equals(passwordTextBox.Text);
                if (!isConfirmationPasswordValid)
                {
                    MessageBox.Show("Passwords do not match. Please ensure the confirmation password matches the original password.");
                    confirmationPasswordTextBox.Clear();
                }

                // If all validations pass, insert user data into the database
                if (isFirstNameValid && isLastNameValid && isEmailValid && isAgeValid && isPhoneValid && isPasswordValid && isConfirmationPasswordValid)
                {
                    string insertQuery = "INSERT INTO Users (Email, FirstName, LastName, Age, Phone, Password, Address) VALUES (@Email, @FirstName, @LastName, @Age, @Phone, @Password, @Address);";
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@Age", Convert.ToInt32(ageTextBox.Text));
                        insertCommand.Parameters.AddWithValue("@Phone", phoneNumbertextBox.Text);
                        insertCommand.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                        insertCommand.Parameters.AddWithValue("@Address", billingAddressTextBox.Text);

                        try
                        {
                            // Execute the insertion query
                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("User registered successfully");
                        }
                        catch (SQLiteException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    // Open WhereToForm after successful registration
                    WhereToForm whereToForm = new WhereToForm();
                    whereToForm.ShowDialog();
                }
            }
        }

        // Close the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Show/hide password functionality
        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '●')
            {
                hidePasswordButton.BringToFront();
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void hidePasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '\0')
            {
                showPasswordButton.BringToFront();
                passwordTextBox.PasswordChar = '●';
            }
        }

        // Show/hide confirmation password functionality
        private void showConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            if (confirmationPasswordTextBox.PasswordChar == '●')
            {
                hideConfirmPasswordButton.BringToFront();
                confirmationPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void hideConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            if (confirmationPasswordTextBox.PasswordChar == '\0')
            {
                showConfirmPasswordButton.BringToFront();
                confirmationPasswordTextBox.PasswordChar = '●';
            }
        }
    }
}
