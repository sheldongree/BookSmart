using ConfirmationPage;
using HotelFilters;
using PayOnlinePaymentMethod;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeDatabase();
            Application.Run(new PayOnlinePaymentMethodForm());
        }
        private static void InitializeDatabase()
        {
            string databasePath = "Hotels.db"; // Change the file path if needed

            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();

                // Create the Hotels table if it doesn't exist
                CreateTable(connection);
            }
        }

        private static void CreateTable(SQLiteConnection connection)
        {
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Hotels
                (
                    Id INTEGER PRIMARY KEY,
                    HotelName TEXT,
                    Rating REAL,
                    Price REAL,
                    NumberOfGuest INTEGER,
                    NumberOfRooms INTEGER,
                    NumberOfBeds INTEGER
                )";

            using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
       

    }
}
