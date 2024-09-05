using ConfirmationPage;
using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PayOnlinePaymentMethod
{
    public partial class PayOnlinePaymentMethodForm : Form
    {
        // Database connection string
        private const string ConnectionString = "Data Source=paymentmethod.db;Version=3;";

        // Regular expressions for validating cardholder name and card number
        string namePattern = @"^[A-Z][a-zA-Z]*-[A-Z][a-zA-Z]*$";
        string cardNumberPattern = @"^\d{16}$";

        public PayOnlinePaymentMethodForm()
        {
            InitializeComponent();
            CreatePaymentMethodTable(); // Ensure table creation during form initialization
        }

        // Method to create PaymentMethod table in the database if it doesn't exist
        private void CreatePaymentMethodTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Create PaymentMethod table if it doesn't exist
                string createTableQuery = "CREATE TABLE IF NOT EXISTS PaymentMethod (ID INTEGER PRIMARY KEY AUTOINCREMENT, CardholderName TEXT, CardNumber TEXT UNIQUE, PaymentType TEXT);";
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
        }

        // Event handler for the validateButton click
        private void validateButton_Click(object sender, EventArgs e)
        {
            // Get cardholder name and card number from the textboxes
            string cardholderName = cardholderNameTextBox.Text;
            string cardNumber = cardholderCardNumberTextBox.Text;

            // Validate cardholder name using regular expression
            bool isNameValid = Regex.IsMatch(cardholderName, namePattern);
            if (!isNameValid)
            {
                MessageBox.Show("Invalid cardholder name. Please ensure the name starts with an uppercase letter, contains only letters, and may include dashes (-).");
                return;
            }

            // Validate card number using regular expression
            bool isCardNumberValid = Regex.IsMatch(cardNumber, cardNumberPattern);
            if (!isCardNumberValid)
            {
                MessageBox.Show("Invalid credit card number. Please ensure the number consists of exactly 16 digits.");
                return;
            }

            // Determine payment type based on checkbox selection
            string paymentType = debitCheckBox.Checked ? "Debit" : "Credit";

            // Check if the card number already exists in the database
            if (IsCardNumberExists(cardNumber))
            {
                MessageBox.Show("This card number already exists. Please use a different card number.");
                return;
            }

            // Save payment method information to the database
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO PaymentMethod (CardholderName, CardNumber, PaymentType) VALUES (@CardholderName, @CardNumber, @PaymentType);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@CardholderName", cardholderName);
                    insertCommand.Parameters.AddWithValue("@CardNumber", cardNumber);
                    insertCommand.Parameters.AddWithValue("@PaymentType", paymentType);

                    try
                    {
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Payment method saved successfully.");
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Display confirmation page
            ConfirmationPageForm confirmPageForm = new ConfirmationPageForm();
            confirmPageForm.ShowDialog();
        }

        // Method to check if a card number already exists in the database
        private bool IsCardNumberExists(string cardNumber)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string checkCardNumberQuery = "SELECT COUNT(*) FROM PaymentMethod WHERE CardNumber = @CardNumber;";
                using (SQLiteCommand checkCardNumberCommand = new SQLiteCommand(checkCardNumberQuery, connection))
                {
                    checkCardNumberCommand.Parameters.AddWithValue("@CardNumber", cardNumber);

                    int cardNumberCount = Convert.ToInt32(checkCardNumberCommand.ExecuteScalar());

                    return cardNumberCount > 0;
                }
            }
        }
    }
}
