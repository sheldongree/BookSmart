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
using static HotelFilters.HotelsForm;

namespace MainPage
{
    public partial class HotelUSAForm : Form
    {
        private int ImageNumber { get; set; } = 0;
        private int ImageNumber2 { get; set; } = 0;
        private int ImageNumber3 { get; set; } = 0;
        private int ImageNumber4 { get; set; } = 0;
        private int ImageNumber5 { get; set; } = 0;
        private int ImageNumber6 { get; set; } = 0;
        private int ImageNumber7 { get; set; } = 0;
        private int ImageNumber8 { get; set; } = 0;
        private int ImageNumber9 { get; set; } = 0;
        private int ImageNumber10 { get; set; } = 0;
        private List<System.Windows.Forms.GroupBox> allGroupBoxes = new List<System.Windows.Forms.GroupBox>();

        public HotelUSAForm()
        {
            InitializeComponent();
            allGroupBoxes.Add(hotelUSA1);
            allGroupBoxes.Add(hotelUSA2);
            allGroupBoxes.Add(hotelUSA3);
            allGroupBoxes.Add(hotelUSA4);
            allGroupBoxes.Add(hotelUSA5);
            allGroupBoxes.Add(hotelUSA6);
            allGroupBoxes.Add(hotelUSA7);
            allGroupBoxes.Add(hotelUSA8);
            allGroupBoxes.Add(hotelUSA9);
            allGroupBoxes.Add(hotelUSA10);



            foreach (System.Windows.Forms.CheckBox checkbox in new[] { starOne, starTwo, starThree, starFour, starFive, price1, price2, price3, numOfGuestCheckBox1, numOfGuestCheckBox2, numOfRooms, numOfRooms2 })
            {
                checkbox.CheckedChanged += Filter_CheckedChanged;
            }

            foreach (System.Windows.Forms.Button button in new[] { availabilityButton, availabilityButton2, availabilityButton3, availabilityButton4, availabilityButton5, availabilityButton6,
            availabilityButton7,availabilityButton8,availabilityButton9,availabilityButton10})
            {
                Click += availabilityButton_Click;
            }
        }


        // usa hotel 1
        private void nextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            hotel1PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel1usa{ImageNumber}")));

        }

        private void prevButton_Click_1(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel1PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel1usa{ImageNumber}")));

        }

        // usa hotel 2
        private void hotel2NextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            hotel2PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel2usa{ImageNumber}")));

        }
        private void hotel2PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel2PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel2usa{ImageNumber}")));

        }

        // usa hotel 3
        private void hotel3NextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            hotel3PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel3usa{ImageNumber}")));
        }

        private void hotel3PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel3PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel3usa{ImageNumber}")));
        }

        // usa hotel 4

        private void hotel4NextButton_Click(object sender, EventArgs e)
        {

            ImageNumber = (ImageNumber + 1) % 3;

            hotel4PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel4usa{ImageNumber}")));
        }

        private void hotel4PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel4PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel4usa{ImageNumber}")));
        }

        // usa hotel 5
        private void hotel5NextButton_Click(object sender, EventArgs e)
        {

            ImageNumber = (ImageNumber + 1) % 3;

            hotel5PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel5usa{ImageNumber}")));
        }

        private void hotel5PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel5PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel5usa{ImageNumber}")));
        }

        private void hotel6NextButton_Click(object sender, EventArgs e)
        {

            ImageNumber = (ImageNumber + 1) % 3;

            hotel6PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel6usa{ImageNumber}")));
        }

        // usa hotel 6
        private void hotel6PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel6PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel6usa{ImageNumber}")));

        }

        // usa hotel 7
        private void hotel7NextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            hotel7PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel7usa{ImageNumber}")));

        }

        private void hotel7PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel7PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel7usa{ImageNumber}")));
        }

        // usa hotel 8

        private void hotel8NextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            hotel8PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel8usa{ImageNumber}")));
        }

        private void hotel8PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel8PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel8usa{ImageNumber}")));

        }

        // usa hotel 9
        private void hotel9NextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            hotel9PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel9usa{ImageNumber}")));
        }

        private void hotel9PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel9PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel9usa{ImageNumber}")));
        }

        // usa hotel 10
        private void hotel10NextButton_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 3;

            hotel10PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel10usa{ImageNumber}")));

        }

        private void hotel10PrevButton_Click(object sender, EventArgs e)
        {
            if (ImageNumber > 0)
            {
                ImageNumber--;
            }
            hotel10PictureBox.Image = (Image)((MainPage.Properties.Resources.ResourceManager.GetObject($"hotel10usa{ImageNumber}")));

        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            List<string> checkedTags = new List<string>();

            // Check for checked star rating checkboxes
            foreach (System.Windows.Forms.CheckBox checkbox in new[] { starOne, starTwo, starThree, starFour, starFive })
            {
                if (checkbox.Checked)
                {
                    string tag = checkbox.Tag?.ToString();
                    if (!string.IsNullOrEmpty(tag))
                    {
                        checkedTags.Add(tag);
                    }
                }
            }
            //check for number of guest checkboxes
            foreach (System.Windows.Forms.CheckBox checkbox in new[] { numOfGuestCheckBox1, numOfGuestCheckBox2 })
            {
                if (checkbox.Checked)
                {
                    string tag = checkbox.Tag?.ToString();
                    if (!string.IsNullOrEmpty(tag))
                    {
                        checkedTags.Add(tag);
                    }
                }
            }
            //check for number of rooms checkboxes
            foreach (System.Windows.Forms.CheckBox checkbox in new[] { numOfRooms, numOfRooms2 })
            {
                if (checkbox.Checked)
                {
                    string tag = checkbox.Tag?.ToString();
                    if (!string.IsNullOrEmpty(tag))
                    {
                        checkedTags.Add(tag);
                    }
                }
            }
            // Check for checked price range checkboxes
            foreach (System.Windows.Forms.CheckBox checkbox in new[] { price1, price2, price3 })
            {
                if (checkbox.Checked)
                {
                    string tag = checkbox.Tag?.ToString();
                    if (!string.IsNullOrEmpty(tag))
                    {
                        checkedTags.Add(tag);
                    }
                }
            }

            if (checkedTags.Count > 0) // If at least one checkbox is checked
            {
                foreach (var groupBox in allGroupBoxes)
                {
                    string groupBoxTag = groupBox.Tag?.ToString();

                    // Show the group box if its tag matches any of the checked tags
                    if (checkedTags.Any(tag => groupBoxTag?.Contains(tag) == true))
                    {
                        groupBox.Visible = true;
                    }
                    else
                    {
                        groupBox.Visible = false;
                    }
                }
            }
            else // If no checkboxes are checked, show all group boxes
            {
                foreach (var groupBox in allGroupBoxes)
                {
                    groupBox.Visible = true;
                }
            }
        }
        private void availabilityButton_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(1); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel1usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton2_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(2); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel2usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton3_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(3); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel3usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton4_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(4); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel4usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton5_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(5); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel5usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton6_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(6); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel6usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton7_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(7); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel7usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton8_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(8); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel8usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton9_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(9); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel9usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        private void availabilityButton10_Click(object sender, EventArgs e)
        {
            // Assuming you have a method GetHotelInformationById to retrieve hotel information by ID
            HotelInformation hotelInfo = GetHotelInformationById(10); // Fetch hotel information for ID 1

            // Check if hotelInfo is not null and then update PaymentMethodForm labels
            if (hotelInfo != null)
            {
                PaymentMethodForm paymentMethodForm = new PaymentMethodForm();

                // Update labels in the PaymentMethodForm with fetched hotel information
                paymentMethodForm.HotelpictureBox.Image = MainPage.Properties.Resources.hotel10usa0;
                paymentMethodForm.hotelNameLabel.Text = hotelInfo.HotelName.ToString();
                paymentMethodForm.displayRatingLabel.Text = hotelInfo.Rating.ToString();
                paymentMethodForm.displayPriceLabel.Text = hotelInfo.Price.ToString();
                paymentMethodForm.displayNumberOfRoomslabel.Text = hotelInfo.NumberOfRooms.ToString();
                paymentMethodForm.displayNumberOfGuestsLabel.Text = hotelInfo.NumberOfGuests.ToString();
                paymentMethodForm.displayNumberOfBedsLabel.Text = hotelInfo.NumberOfBeds.ToString();
                paymentMethodForm.displayFinalPriceLabel.Text = CalculateFinalPrice(hotelInfo.Price).ToString();

                paymentMethodForm.ShowDialog();

            }

        }
        public class HotelInformation
        {
            public int Id { get; set; }
            public string HotelName { get; set; }
            public double Rating { get; set; }
            public double Price { get; set; }
            public int NumberOfGuests { get; set; }
            public int NumberOfRooms { get; set; }
            public int NumberOfBeds { get; set; }
            // Other properties as per your database schema
        }
        public static HotelInformation GetHotelInformationById(int id)
        {
            HotelInformation hotelInfo = null;
            string databasePath = "HotelsUS.db"; // Update the path to your SQLite database

            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();

                // Query to select hotel information by ID
                string query = "SELECT * FROM Hotels WHERE Id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate hotelInfo object with retrieved data
                            hotelInfo = new HotelInformation
                            {

                                Id = Convert.ToInt32(reader["Id"]),
                                HotelName = reader["HotelName"].ToString(),
                                Rating = Convert.ToDouble(reader["Rating"]),
                                Price = Convert.ToDouble(reader["Price"]),
                                NumberOfGuests = Convert.ToInt32(reader["NumberOfGuest"]),
                                NumberOfRooms = Convert.ToInt32(reader["NumberOfRooms"]),
                                NumberOfBeds = Convert.ToInt32(reader["NumberOfBeds"])
                                // Map other columns similarly
                            };
                        }
                    }
                }
            }

            return hotelInfo;
        }
        private static string CalculateFinalPrice(double originalPrice)
        {
            // Example: Adding tax and service charges to the original price
            double taxRate = 0.10; // 10% tax
            double serviceCharge = 20.0; // Fixed service charge
            double numberOfDays = 3;
            double totalDaysCost = originalPrice * numberOfDays;

            // Calculate the final price by adding tax and service charges
            double finalPrice = totalDaysCost + (totalDaysCost * taxRate) + serviceCharge;

            return $"${finalPrice}";
        }



    

}
}

