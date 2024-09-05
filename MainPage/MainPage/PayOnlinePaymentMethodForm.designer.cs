namespace PayOnlinePaymentMethod
{
    partial class PayOnlinePaymentMethodForm
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
            this.PayOnlinePaymentMethod = new System.Windows.Forms.Label();
            this.cardholderNameLabel = new System.Windows.Forms.Label();
            this.cardholderNameTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardholderCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.creditCheckBox = new System.Windows.Forms.RadioButton();
            this.debitCheckBox = new System.Windows.Forms.RadioButton();
            this.validateButton = new System.Windows.Forms.Button();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PayOnlinePaymentMethod
            // 
            this.PayOnlinePaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.PayOnlinePaymentMethod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayOnlinePaymentMethod.ForeColor = System.Drawing.Color.White;
            this.PayOnlinePaymentMethod.Location = new System.Drawing.Point(224, 6);
            this.PayOnlinePaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PayOnlinePaymentMethod.Name = "PayOnlinePaymentMethod";
            this.PayOnlinePaymentMethod.Size = new System.Drawing.Size(185, 47);
            this.PayOnlinePaymentMethod.TabIndex = 0;
            this.PayOnlinePaymentMethod.Text = "Secure Payment";
            // 
            // cardholderNameLabel
            // 
            this.cardholderNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardholderNameLabel.ForeColor = System.Drawing.Color.White;
            this.cardholderNameLabel.Location = new System.Drawing.Point(21, 86);
            this.cardholderNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardholderNameLabel.Name = "cardholderNameLabel";
            this.cardholderNameLabel.Size = new System.Drawing.Size(129, 15);
            this.cardholderNameLabel.TabIndex = 2;
            this.cardholderNameLabel.Text = "Cardholder Name:";
            // 
            // cardholderNameTextBox
            // 
            this.cardholderNameTextBox.Location = new System.Drawing.Point(173, 84);
            this.cardholderNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardholderNameTextBox.Name = "cardholderNameTextBox";
            this.cardholderNameTextBox.Size = new System.Drawing.Size(206, 22);
            this.cardholderNameTextBox.TabIndex = 3;
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberLabel.ForeColor = System.Drawing.Color.White;
            this.cardNumberLabel.Location = new System.Drawing.Point(21, 132);
            this.cardNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(92, 18);
            this.cardNumberLabel.TabIndex = 4;
            this.cardNumberLabel.Text = "Card Number:";
            // 
            // cardholderCardNumberTextBox
            // 
            this.cardholderCardNumberTextBox.Location = new System.Drawing.Point(173, 129);
            this.cardholderCardNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardholderCardNumberTextBox.Name = "cardholderCardNumberTextBox";
            this.cardholderCardNumberTextBox.Size = new System.Drawing.Size(206, 22);
            this.cardholderCardNumberTextBox.TabIndex = 5;
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.paymentGroupBox.Controls.Add(this.creditCheckBox);
            this.paymentGroupBox.Controls.Add(this.debitCheckBox);
            this.paymentGroupBox.Controls.Add(this.cardholderCardNumberTextBox);
            this.paymentGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentGroupBox.Controls.Add(this.cardholderNameTextBox);
            this.paymentGroupBox.Controls.Add(this.cardholderNameLabel);
            this.paymentGroupBox.Location = new System.Drawing.Point(104, 41);
            this.paymentGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.paymentGroupBox.Size = new System.Drawing.Size(399, 198);
            this.paymentGroupBox.TabIndex = 1;
            this.paymentGroupBox.TabStop = false;
            // 
            // creditCheckBox
            // 
            this.creditCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCheckBox.ForeColor = System.Drawing.Color.White;
            this.creditCheckBox.Location = new System.Drawing.Point(211, 18);
            this.creditCheckBox.Name = "creditCheckBox";
            this.creditCheckBox.Size = new System.Drawing.Size(168, 20);
            this.creditCheckBox.TabIndex = 0;
            this.creditCheckBox.TabStop = true;
            this.creditCheckBox.Text = "Credit VISA/Mastercard";
            this.creditCheckBox.UseVisualStyleBackColor = true;
            // 
            // debitCheckBox
            // 
            this.debitCheckBox.AutoSize = true;
            this.debitCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitCheckBox.ForeColor = System.Drawing.Color.White;
            this.debitCheckBox.Location = new System.Drawing.Point(24, 18);
            this.debitCheckBox.Name = "debitCheckBox";
            this.debitCheckBox.Size = new System.Drawing.Size(99, 22);
            this.debitCheckBox.TabIndex = 6;
            this.debitCheckBox.TabStop = true;
            this.debitCheckBox.Text = "Debit VISA";
            this.debitCheckBox.UseVisualStyleBackColor = true;
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(219, 244);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(168, 45);
            this.validateButton.TabIndex = 7;
            this.validateButton.Text = "Validate";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // PayOnlinePaymentMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainPage.Properties.Resources.payOnlinePaymentMethodImage;
            this.ClientSize = new System.Drawing.Size(633, 368);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.PayOnlinePaymentMethod);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PayOnlinePaymentMethodForm";
            this.Text = "Payment Verification";
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PayOnlinePaymentMethod;
        private System.Windows.Forms.Label cardholderNameLabel;
        private System.Windows.Forms.TextBox cardholderNameTextBox;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox cardholderCardNumberTextBox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.RadioButton creditCheckBox;
        private System.Windows.Forms.RadioButton debitCheckBox;
        private System.Windows.Forms.Button validateButton;
    }
}

