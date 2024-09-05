namespace MainPage
{
    partial class PaymentMethodForm
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
            this.paymentLabel = new System.Windows.Forms.Label();
            this.onlinePaymentbutton = new System.Windows.Forms.Button();
            this.receptionPaymentbutton = new System.Windows.Forms.Button();
            this.hotelInformationgroupBox = new System.Windows.Forms.GroupBox();
            this.hotelNameLabel = new System.Windows.Forms.Label();
            this.displayFinalPriceLabel = new System.Windows.Forms.Label();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.displayNumberOfBedsLabel = new System.Windows.Forms.Label();
            this.displayNumberOfGuestsLabel = new System.Windows.Forms.Label();
            this.displayNumberOfRoomslabel = new System.Windows.Forms.Label();
            this.displayPriceLabel = new System.Windows.Forms.Label();
            this.displayRatingLabel = new System.Windows.Forms.Label();
            this.numberOfBedsLabel = new System.Windows.Forms.Label();
            this.numberOfGuestsLabel = new System.Windows.Forms.Label();
            this.numberOfRoomslabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.HotelpictureBox = new System.Windows.Forms.PictureBox();
            this.hotelInformationgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.BackColor = System.Drawing.Color.Transparent;
            this.paymentLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.Color.White;
            this.paymentLabel.Location = new System.Drawing.Point(212, 431);
            this.paymentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(539, 38);
            this.paymentLabel.TabIndex = 0;
            this.paymentLabel.Text = "How would like to make your payment ?";
            // 
            // onlinePaymentbutton
            // 
            this.onlinePaymentbutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePaymentbutton.Location = new System.Drawing.Point(219, 481);
            this.onlinePaymentbutton.Margin = new System.Windows.Forms.Padding(4);
            this.onlinePaymentbutton.Name = "onlinePaymentbutton";
            this.onlinePaymentbutton.Size = new System.Drawing.Size(255, 90);
            this.onlinePaymentbutton.TabIndex = 1;
            this.onlinePaymentbutton.Text = "Online";
            this.onlinePaymentbutton.UseVisualStyleBackColor = true;
            this.onlinePaymentbutton.Click += new System.EventHandler(this.onlinePaymentbutton_Click);
            // 
            // receptionPaymentbutton
            // 
            this.receptionPaymentbutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.receptionPaymentbutton.Location = new System.Drawing.Point(515, 481);
            this.receptionPaymentbutton.Margin = new System.Windows.Forms.Padding(4);
            this.receptionPaymentbutton.Name = "receptionPaymentbutton";
            this.receptionPaymentbutton.Size = new System.Drawing.Size(255, 90);
            this.receptionPaymentbutton.TabIndex = 2;
            this.receptionPaymentbutton.Text = "Reception";
            this.receptionPaymentbutton.UseVisualStyleBackColor = true;
            this.receptionPaymentbutton.Click += new System.EventHandler(this.receptionPaymentbutton_Click);
            // 
            // hotelInformationgroupBox
            // 
            this.hotelInformationgroupBox.BackColor = System.Drawing.Color.Transparent;
            this.hotelInformationgroupBox.Controls.Add(this.hotelNameLabel);
            this.hotelInformationgroupBox.Controls.Add(this.displayFinalPriceLabel);
            this.hotelInformationgroupBox.Controls.Add(this.finalPriceLabel);
            this.hotelInformationgroupBox.Controls.Add(this.displayNumberOfBedsLabel);
            this.hotelInformationgroupBox.Controls.Add(this.displayNumberOfGuestsLabel);
            this.hotelInformationgroupBox.Controls.Add(this.displayNumberOfRoomslabel);
            this.hotelInformationgroupBox.Controls.Add(this.displayPriceLabel);
            this.hotelInformationgroupBox.Controls.Add(this.displayRatingLabel);
            this.hotelInformationgroupBox.Controls.Add(this.numberOfBedsLabel);
            this.hotelInformationgroupBox.Controls.Add(this.numberOfGuestsLabel);
            this.hotelInformationgroupBox.Controls.Add(this.numberOfRoomslabel);
            this.hotelInformationgroupBox.Controls.Add(this.priceLabel);
            this.hotelInformationgroupBox.Controls.Add(this.firstNameTextBox);
            this.hotelInformationgroupBox.Controls.Add(this.ratingLabel);
            this.hotelInformationgroupBox.Controls.Add(this.HotelpictureBox);
            this.hotelInformationgroupBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelInformationgroupBox.ForeColor = System.Drawing.Color.White;
            this.hotelInformationgroupBox.Location = new System.Drawing.Point(16, 15);
            this.hotelInformationgroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.hotelInformationgroupBox.Name = "hotelInformationgroupBox";
            this.hotelInformationgroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.hotelInformationgroupBox.Size = new System.Drawing.Size(944, 412);
            this.hotelInformationgroupBox.TabIndex = 3;
            this.hotelInformationgroupBox.TabStop = false;
            this.hotelInformationgroupBox.Text = "Hotel\'s Info";
            // 
            // hotelNameLabel
            // 
            this.hotelNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.hotelNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hotelNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelNameLabel.ForeColor = System.Drawing.Color.White;
            this.hotelNameLabel.Location = new System.Drawing.Point(0, 373);
            this.hotelNameLabel.Name = "hotelNameLabel";
            this.hotelNameLabel.Size = new System.Drawing.Size(483, 35);
            this.hotelNameLabel.TabIndex = 34;
            this.hotelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayFinalPriceLabel
            // 
            this.displayFinalPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.displayFinalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayFinalPriceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayFinalPriceLabel.Location = new System.Drawing.Point(639, 245);
            this.displayFinalPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayFinalPriceLabel.Name = "displayFinalPriceLabel";
            this.displayFinalPriceLabel.Size = new System.Drawing.Size(297, 28);
            this.displayFinalPriceLabel.TabIndex = 33;
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPriceLabel.ForeColor = System.Drawing.Color.White;
            this.finalPriceLabel.Location = new System.Drawing.Point(499, 245);
            this.finalPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(131, 28);
            this.finalPriceLabel.TabIndex = 32;
            this.finalPriceLabel.Text = "Final price :";
            // 
            // displayNumberOfBedsLabel
            // 
            this.displayNumberOfBedsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.displayNumberOfBedsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayNumberOfBedsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayNumberOfBedsLabel.Location = new System.Drawing.Point(639, 201);
            this.displayNumberOfBedsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayNumberOfBedsLabel.Name = "displayNumberOfBedsLabel";
            this.displayNumberOfBedsLabel.Size = new System.Drawing.Size(297, 28);
            this.displayNumberOfBedsLabel.TabIndex = 27;
            // 
            // displayNumberOfGuestsLabel
            // 
            this.displayNumberOfGuestsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.displayNumberOfGuestsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayNumberOfGuestsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayNumberOfGuestsLabel.Location = new System.Drawing.Point(639, 158);
            this.displayNumberOfGuestsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayNumberOfGuestsLabel.Name = "displayNumberOfGuestsLabel";
            this.displayNumberOfGuestsLabel.Size = new System.Drawing.Size(297, 28);
            this.displayNumberOfGuestsLabel.TabIndex = 26;
            // 
            // displayNumberOfRoomslabel
            // 
            this.displayNumberOfRoomslabel.BackColor = System.Drawing.SystemColors.Control;
            this.displayNumberOfRoomslabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayNumberOfRoomslabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayNumberOfRoomslabel.Location = new System.Drawing.Point(639, 113);
            this.displayNumberOfRoomslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayNumberOfRoomslabel.Name = "displayNumberOfRoomslabel";
            this.displayNumberOfRoomslabel.Size = new System.Drawing.Size(297, 28);
            this.displayNumberOfRoomslabel.TabIndex = 25;
            // 
            // displayPriceLabel
            // 
            this.displayPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.displayPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPriceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayPriceLabel.Location = new System.Drawing.Point(639, 68);
            this.displayPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayPriceLabel.Name = "displayPriceLabel";
            this.displayPriceLabel.Size = new System.Drawing.Size(297, 28);
            this.displayPriceLabel.TabIndex = 24;
            // 
            // displayRatingLabel
            // 
            this.displayRatingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.displayRatingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayRatingLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayRatingLabel.Location = new System.Drawing.Point(639, 23);
            this.displayRatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayRatingLabel.Name = "displayRatingLabel";
            this.displayRatingLabel.Size = new System.Drawing.Size(297, 28);
            this.displayRatingLabel.TabIndex = 23;
            // 
            // numberOfBedsLabel
            // 
            this.numberOfBedsLabel.AutoSize = true;
            this.numberOfBedsLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.numberOfBedsLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfBedsLabel.Location = new System.Drawing.Point(499, 201);
            this.numberOfBedsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfBedsLabel.Name = "numberOfBedsLabel";
            this.numberOfBedsLabel.Size = new System.Drawing.Size(118, 19);
            this.numberOfBedsLabel.TabIndex = 21;
            this.numberOfBedsLabel.Text = "Number of beds:";
            // 
            // numberOfGuestsLabel
            // 
            this.numberOfGuestsLabel.AutoSize = true;
            this.numberOfGuestsLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.numberOfGuestsLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfGuestsLabel.Location = new System.Drawing.Point(499, 158);
            this.numberOfGuestsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfGuestsLabel.Name = "numberOfGuestsLabel";
            this.numberOfGuestsLabel.Size = new System.Drawing.Size(130, 19);
            this.numberOfGuestsLabel.TabIndex = 20;
            this.numberOfGuestsLabel.Text = "Number of guests:";
            // 
            // numberOfRoomslabel
            // 
            this.numberOfRoomslabel.AutoSize = true;
            this.numberOfRoomslabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.numberOfRoomslabel.ForeColor = System.Drawing.Color.White;
            this.numberOfRoomslabel.Location = new System.Drawing.Point(499, 113);
            this.numberOfRoomslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfRoomslabel.Name = "numberOfRoomslabel";
            this.numberOfRoomslabel.Size = new System.Drawing.Size(126, 19);
            this.numberOfRoomslabel.TabIndex = 17;
            this.numberOfRoomslabel.Text = "Number of rooms:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(499, 68);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(46, 19);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "Price:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.AcceptsReturn = true;
            this.firstNameTextBox.Location = new System.Drawing.Point(639, 23);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(0, 27);
            this.firstNameTextBox.TabIndex = 14;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.Color.White;
            this.ratingLabel.Location = new System.Drawing.Point(499, 23);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(61, 19);
            this.ratingLabel.TabIndex = 13;
            this.ratingLabel.Text = "Ratings:";
            // 
            // HotelpictureBox
            // 
            this.HotelpictureBox.Location = new System.Drawing.Point(0, 23);
            this.HotelpictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.HotelpictureBox.Name = "HotelpictureBox";
            this.HotelpictureBox.Size = new System.Drawing.Size(483, 346);
            this.HotelpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HotelpictureBox.TabIndex = 0;
            this.HotelpictureBox.TabStop = false;
            // 
            // PaymentMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainPage.Properties.Resources.paymentMethodImage;
            this.ClientSize = new System.Drawing.Size(1041, 618);
            this.Controls.Add(this.hotelInformationgroupBox);
            this.Controls.Add(this.receptionPaymentbutton);
            this.Controls.Add(this.onlinePaymentbutton);
            this.Controls.Add(this.paymentLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentMethodForm";
            this.Text = "Payment Method";
            this.hotelInformationgroupBox.ResumeLayout(false);
            this.hotelInformationgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Button onlinePaymentbutton;
        private System.Windows.Forms.Button receptionPaymentbutton;
        private System.Windows.Forms.GroupBox hotelInformationgroupBox;
        private System.Windows.Forms.Label numberOfBedsLabel;
        private System.Windows.Forms.Label numberOfGuestsLabel;
        private System.Windows.Forms.Label numberOfRoomslabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label finalPriceLabel;
        public System.Windows.Forms.Label displayRatingLabel;
        public System.Windows.Forms.Label displayNumberOfBedsLabel;
        public System.Windows.Forms.Label displayNumberOfGuestsLabel;
        public System.Windows.Forms.Label displayNumberOfRoomslabel;
        public System.Windows.Forms.Label displayPriceLabel;
        public System.Windows.Forms.Label displayFinalPriceLabel;
        public System.Windows.Forms.Label hotelNameLabel;
        public System.Windows.Forms.PictureBox HotelpictureBox;
    }
}