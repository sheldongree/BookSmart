using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfirmationPage
{
    public partial class ConfirmationPageForm : Form
    {
        // Connection string for SQLite database
        private const string ConnectionString = "Data Source=confirmation.db;Version=3;";

        public ConfirmationPageForm()
        {
            InitializeComponent();
        }

        // Event handler when the ConfirmationPageForm is loaded
        private void ConfirmationPageForm_Load(object sender, EventArgs e)
        {
            // Generate a random 10-digit confirmation number
            string confirmationNumber = GenerateRandomConfirmationNumber();

            // Display the confirmation number
            displayConfirmationNumberlabel.Text = confirmationNumber;

            // Store the confirmation information in the database
            StoreConfirmationInformationInDatabase(confirmationNumber);

            // Display today's date for check-in
            displayCheckInDateLabel.Text = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");

            // Display the date three days later for check-out
            displayCheckOutDateLabel.Text = DateTime.Now.AddMonths(1).AddDays(3).ToString("yyyy-MM-dd");
        }


        // Method to generate a random 10-digit confirmation number
        private string GenerateRandomConfirmationNumber()
        {
            Random random = new Random();
            return random.Next(100000000, 999999999).ToString("D9");
        }

        // Method to store confirmation information in the database
        private void StoreConfirmationInformationInDatabase(string confirmationNumber)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Create Confirmation table if it doesn't exist
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Confirmation (ID INTEGER PRIMARY KEY AUTOINCREMENT, ConfirmationNumber TEXT UNIQUE, CheckIn TEXT, CheckOut TEXT);";
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                // Get today's date for check-in
                string checkInDate = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");

                // Get the date three days later for check-out
                string checkOutDate = DateTime.Now.AddMonths(1).AddDays(3).ToString("yyyy-MM-dd");

                // Insert confirmation information into the database
                string insertQuery = "INSERT INTO Confirmation (ConfirmationNumber, CheckIn, CheckOut) VALUES (@ConfirmationNumber, @CheckIn, @CheckOut);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@ConfirmationNumber", confirmationNumber);
                    insertCommand.Parameters.AddWithValue("@CheckIn", checkInDate);
                    insertCommand.Parameters.AddWithValue("@CheckOut", checkOutDate);

                    try
                    {
                        insertCommand.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error storing confirmation information: " + ex.Message);
                    }
                }
            }
        }
    }
}
