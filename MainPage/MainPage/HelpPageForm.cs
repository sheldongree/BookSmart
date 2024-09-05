using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpPage
{
    public partial class HelpPageForm : Form
    {
        // Lists to store images and instructions
        public List<Image> images = new List<Image>();
        public List<string> instructions = new List<string>();
        public int ImageIndex = 0;

        public HelpPageForm()
        {
            // Root directory where image files are stored
            string root = "C:\\Users\\fatim\\Downloads\\AppDevProject\\MainPage\\MainPage\\Resources\\"; // Change path here

            InitializeComponent();

            // Adding instructions to the list
            instructions.Add("If you don't have an account click here to Sign Up");
            instructions.Add("Enter you information and click the confirm button");
            instructions.Add("Choose where would you like to go");
            instructions.Add("Pick the hotel using the filters if needed");
            instructions.Add("Confirm your information and choose the payment method");
            instructions.Add("If chosen the online payment please fill in the requirements");
            instructions.Add("Finally, you will be sent a confirmation to your email");

            // Loading images from files and adding them to the list
            for (int i = 0; i < instructions.Count; i++)
            {
                images.Add(Image.FromFile(Path.Combine(root + i + ".png")));
            }

            // Refresh the display with the initial image and instruction
            Refresh();
        }

        // Method to refresh the displayed image and instruction
        public override void Refresh()
        {
            instructionPictureBox.Image = images[ImageIndex];
            instructionLabel.Text = instructions[ImageIndex];
        }

        // Event handler for the previous button
        private void previousButton_Click(object sender, EventArgs e)
        {
            // Move to the previous image in the list
            ImageIndex--;

            // If reached the first image, loop back to the last image
            if (ImageIndex < 0)
            {
                ImageIndex = images.Count - 1;
            }

            // Ensure ImageIndex is within the valid range
            ImageIndex = ImageIndex % images.Count;

            // Refresh the display with the updated image and instruction
            Refresh();
        }

        // Event handler for the next button
        private void nextButton_Click(object sender, EventArgs e)
        {
            // Move to the next image in the list
            ImageIndex++;

            // Ensure ImageIndex is within the valid range
            ImageIndex = ImageIndex % images.Count;

            // Refresh the display with the updated image and instruction
            Refresh();
        }
    }
}
