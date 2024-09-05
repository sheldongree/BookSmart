using ConfirmationPage;
using HotelFilters;
using PayOnlinePaymentMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage
{
    public partial class PaymentMethodForm : Form
    {
        public PaymentMethodForm()
        {
            InitializeComponent();
        }

        // Event handler for reception payment button click
        private void receptionPaymentbutton_Click(object sender, EventArgs e)
        {
            // Open ConfirmationPageForm for reception payment
            ConfirmationPageForm confirmationPage = new ConfirmationPageForm();
            confirmationPage.ShowDialog();
        }

        // Event handler for online payment button click
        private void onlinePaymentbutton_Click(object sender, EventArgs e)
        {
            // Open PayOnlinePaymentMethodForm for online payment
            PayOnlinePaymentMethodForm payOnlinePaymentMethodForm = new PayOnlinePaymentMethodForm();
            payOnlinePaymentMethodForm.ShowDialog();
        }

        // Method to display hotel information on the form
        public void DisplayHotelInformation(int id, string hotelName, double ratings, int numberOfRooms, int numberOfGuests, int numberOfBeds, double pricePerNight)
        {
            // Create a new HotelsForm instance
            HotelsForm hotel = new HotelsForm();

            // Display received hotel information in different labels
            // Note: You might need to adjust this part based on the actual UI elements in your form
            Bitmap image = Properties.Resources.image4;
            HotelpictureBox.Image = image; // Display hotel image
            ratingLabel.Text = ratings.ToString(); // Display hotel ratings
            numberOfRoomslabel.Text = numberOfRooms.ToString(); // Display number of rooms
            numberOfGuestsLabel.Text = numberOfGuests.ToString(); // Display number of guests
            numberOfBedsLabel.Text = numberOfBeds.ToString(); // Display number of beds
            priceLabel.Text = pricePerNight.ToString(); // Display price per night
            hotelNameLabel.Text = hotelName.ToString();
        }
    }
}
