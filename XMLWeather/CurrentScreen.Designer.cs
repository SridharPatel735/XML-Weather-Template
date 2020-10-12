namespace XMLWeather
{
    partial class CurrentScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.minMaxOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.updateTemp = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.windLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hourly1 = new System.Windows.Forms.Label();
            this.hourly2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(119, 9);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(136, 35);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minMaxOutput
            // 
            this.minMaxOutput.BackColor = System.Drawing.Color.Transparent;
            this.minMaxOutput.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minMaxOutput.ForeColor = System.Drawing.Color.White;
            this.minMaxOutput.Location = new System.Drawing.Point(82, 164);
            this.minMaxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minMaxOutput.Name = "minMaxOutput";
            this.minMaxOutput.Size = new System.Drawing.Size(79, 26);
            this.minMaxOutput.TabIndex = 30;
            this.minMaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(196, 209);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(33, 20);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(119, 71);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(164, 82);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(66, 618);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(250, 56);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeLabel.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.ForeColor = System.Drawing.Color.White;
            this.dateTimeLabel.Location = new System.Drawing.Point(73, 44);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(229, 27);
            this.dateTimeLabel.TabIndex = 43;
            this.dateTimeLabel.Text = "label1";
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeLabel.Location = new System.Drawing.Point(163, 164);
            this.feelsLikeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(150, 26);
            this.feelsLikeLabel.TabIndex = 44;
            this.feelsLikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(20, 203);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(339, 26);
            this.conditionLabel.TabIndex = 45;
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // updateTemp
            // 
            this.updateTemp.Enabled = true;
            this.updateTemp.Interval = 30000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::XMLWeather.Properties.Resources.Untitled_drawing__4_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 85);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // windLabel1
            // 
            this.windLabel1.BackColor = System.Drawing.Color.Transparent;
            this.windLabel1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel1.ForeColor = System.Drawing.Color.White;
            this.windLabel1.Location = new System.Drawing.Point(34, 289);
            this.windLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windLabel1.Name = "windLabel1";
            this.windLabel1.Size = new System.Drawing.Size(87, 58);
            this.windLabel1.TabIndex = 47;
            this.windLabel1.Text = "HIIIIIII";
            this.windLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(20, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "Wind Speed and Direction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windLabel2
            // 
            this.windLabel2.BackColor = System.Drawing.Color.Transparent;
            this.windLabel2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel2.ForeColor = System.Drawing.Color.White;
            this.windLabel2.Location = new System.Drawing.Point(153, 289);
            this.windLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windLabel2.Name = "windLabel2";
            this.windLabel2.Size = new System.Drawing.Size(194, 58);
            this.windLabel2.TabIndex = 49;
            this.windLabel2.Text = "HIIIIIII";
            this.windLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 58);
            this.label4.TabIndex = 50;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Hourly";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::XMLWeather.Properties.Resources.Untitled_drawing__4_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-15, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(408, 215);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // hourly1
            // 
            this.hourly1.BackColor = System.Drawing.Color.Transparent;
            this.hourly1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourly1.ForeColor = System.Drawing.Color.White;
            this.hourly1.Location = new System.Drawing.Point(45, 435);
            this.hourly1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourly1.Name = "hourly1";
            this.hourly1.Size = new System.Drawing.Size(130, 148);
            this.hourly1.TabIndex = 53;
            this.hourly1.Text = "6:00";
            this.hourly1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourly2
            // 
            this.hourly2.BackColor = System.Drawing.Color.Transparent;
            this.hourly2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourly2.ForeColor = System.Drawing.Color.White;
            this.hourly2.Location = new System.Drawing.Point(203, 435);
            this.hourly2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourly2.Name = "hourly2";
            this.hourly2.Size = new System.Drawing.Size(130, 148);
            this.hourly2.TabIndex = 54;
            this.hourly2.Text = "7:00";
            this.hourly2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(234, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 46);
            this.label6.TabIndex = 55;
            this.label6.Text = "C";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(49, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 82);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::XMLWeather.Properties.Resources.Untitled_drawing__4_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-15, 610);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(408, 85);
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.Untitled_drawing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hourly2);
            this.Controls.Add(this.hourly1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.windLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.minMaxOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(375, 690);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label minMaxOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer updateTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label windLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label windLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label hourly1;
        private System.Windows.Forms.Label hourly2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
