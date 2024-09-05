using HotelFilters;
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
    public partial class WhereToForm : Form
    {
        public WhereToForm()
        {
            InitializeComponent();
        }

        // Event handler for the Canada button click
        private void canadaButton_Click(object sender, EventArgs e)
        {
            // Open the HotelsForm for Canada
            HotelsForm hotelsForm = new HotelsForm();
            hotelsForm.ShowDialog();
        }

        // Event handler for the United States button click
        private void unitedStatesButton_Click(object sender, EventArgs e)
        {
            // Open the HotelsForm for the United States
            HotelUSAForm hotelsForm = new HotelUSAForm();
            hotelsForm.ShowDialog();
        }
    }
}
