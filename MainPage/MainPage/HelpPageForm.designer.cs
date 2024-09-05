namespace HelpPage
{
    partial class HelpPageForm
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
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.instructionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.instructionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(12, 432);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(160, 58);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "< Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(621, 432);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(160, 58);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.White;
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(178, 432);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(437, 58);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionPictureBox
            // 
            this.instructionPictureBox.Location = new System.Drawing.Point(12, 12);
            this.instructionPictureBox.Name = "instructionPictureBox";
            this.instructionPictureBox.Size = new System.Drawing.Size(769, 400);
            this.instructionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instructionPictureBox.TabIndex = 0;
            this.instructionPictureBox.TabStop = false;
            // 
            // HelpPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(793, 502);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.instructionPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HelpPageForm";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.instructionPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox instructionPictureBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label instructionLabel;
    }
}

