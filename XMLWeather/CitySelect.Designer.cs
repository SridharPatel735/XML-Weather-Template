namespace XMLWeather
{
    partial class CitySelect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(3, 157);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(369, 164);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Please enter the city and country name i.e. stratford,ca.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "City Selection";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(10, 308);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(344, 26);
            this.cityInput.TabIndex = 2;
            // 
            // continueButton
            // 
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(10, 356);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(344, 101);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // tryAgain
            // 
            this.tryAgain.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.ForeColor = System.Drawing.Color.White;
            this.tryAgain.Location = new System.Drawing.Point(3, 478);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(369, 164);
            this.tryAgain.TabIndex = 4;
            // 
            // CitySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Untitled_drawing;
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "CitySelect";
            this.Size = new System.Drawing.Size(375, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label tryAgain;
    }
}
