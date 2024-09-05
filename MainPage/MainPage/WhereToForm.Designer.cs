namespace MainPage
{
    partial class WhereToForm
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
            this.unitedStatesButton = new System.Windows.Forms.Button();
            this.canadaButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unitedStatesButton
            // 
            this.unitedStatesButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitedStatesButton.Location = new System.Drawing.Point(147, 245);
            this.unitedStatesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitedStatesButton.Name = "unitedStatesButton";
            this.unitedStatesButton.Size = new System.Drawing.Size(272, 141);
            this.unitedStatesButton.TabIndex = 5;
            this.unitedStatesButton.Text = "United States";
            this.unitedStatesButton.UseVisualStyleBackColor = true;
            this.unitedStatesButton.Click += new System.EventHandler(this.unitedStatesButton_Click);
            // 
            // canadaButton
            // 
            this.canadaButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canadaButton.Location = new System.Drawing.Point(147, 80);
            this.canadaButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.canadaButton.Name = "canadaButton";
            this.canadaButton.Size = new System.Drawing.Size(272, 141);
            this.canadaButton.TabIndex = 4;
            this.canadaButton.Text = "Canada";
            this.canadaButton.UseVisualStyleBackColor = true;
            this.canadaButton.Click += new System.EventHandler(this.canadaButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(67, 5);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(441, 71);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Where to?";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhereToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainPage.Properties.Resources.whereToImage;
            this.ClientSize = new System.Drawing.Size(574, 390);
            this.Controls.Add(this.unitedStatesButton);
            this.Controls.Add(this.canadaButton);
            this.Controls.Add(this.textLabel);
            this.Name = "WhereToForm";
            this.Text = "WhereToForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unitedStatesButton;
        private System.Windows.Forms.Button canadaButton;
        private System.Windows.Forms.Label textLabel;
    }
}