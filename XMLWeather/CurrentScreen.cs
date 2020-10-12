using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            label4.Text = "|\n|";
            //windLabel.Parent = pictureBox1;
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //Change background color depending on the time of day and weather
            double weatherNum = Convert.ToDouble(Form1.days[0].weatherNumber);
            if (weatherNum >= 200 && weatherNum <= 232)
            {
                pictureBox3.BackgroundImage = Properties.Resources._11n;
            }
            else if (weatherNum >= 300 && weatherNum <= 321)
            {
                pictureBox3.BackgroundImage = Properties.Resources._09n;
            }
            else if (weatherNum >= 500 && weatherNum <= 504)
            {
                pictureBox3.BackgroundImage = Properties.Resources._10d;
            }
            else if (weatherNum == 511)
            {
                pictureBox3.BackgroundImage = Properties.Resources._13d;
            }
            else if (weatherNum >= 520 && weatherNum <= 531)
            {
                pictureBox3.BackgroundImage = Properties.Resources._09n;
            }
            else if (weatherNum >= 600 && weatherNum <= 622)
            {
                pictureBox3.BackgroundImage = Properties.Resources._13d;
            }
            else if (weatherNum >= 701 && weatherNum <= 781)
            {
                pictureBox3.BackgroundImage = Properties.Resources._50n;
            }
            else if (weatherNum == 800)
            {
                pictureBox3.BackgroundImage = Properties.Resources._01d;
            }
            else if (weatherNum == 801)
            {
                pictureBox3.BackgroundImage = Properties.Resources._02d;
            }
            else if (weatherNum == 802)
            {
                pictureBox3.BackgroundImage = Properties.Resources._03d;
            }
            else if (weatherNum == 803 || weatherNum == 804)
            {
                pictureBox3.BackgroundImage = Properties.Resources._04n;
            }

            cityOutput.Text = Form1.days[0].location;
            dateTimeLabel.Text = Form1.days[0].date + " " + Form1.days[0].currentTime;
            double currentTemp = Convert.ToDouble(Form1.days[0].currentTemp);
            tempLabel.Text = currentTemp.ToString("##") + "\u00B0" + "C";

            double minTemp = Convert.ToDouble(Form1.days[0].tempLow);
            tempLabel.Text = currentTemp.ToString("##") + "\u00B0";
            double maxTemp = Convert.ToDouble(Form1.days[0].tempHigh);
            tempLabel.Text = currentTemp.ToString("##") + "\u00B0";
            minMaxOutput.Text = maxTemp.ToString("##") + "\u00B0" + "/" + minTemp.ToString("##") + "\u00B0";

            double feelsTemp = Convert.ToDouble(Form1.days[0].feelsLike);
            feelsLikeLabel.Text = "Feels Like: " + feelsTemp.ToString("##") + "\u00B0";
            conditionLabel.Text = Form1.days[0].condition;

            double windSpeed = Convert.ToDouble(Form1.days[0].windSpeed);
            windSpeed = windSpeed * 3.6;
            windLabel1.Text = windSpeed.ToString("##") + "km/h";
            windLabel2.Text = Form1.days[0].windDirection;

            string currentString = Form1.days[0].currentTime;
            DateTime hour1 = DateTime.Parse(currentString);
            if (hour1.Minute > 0)
            {
                hour1 = hour1.AddMinutes(-hour1.Minute);
            }
            hour1 = hour1.AddMinutes(60);
            hourly1.Text = hour1 + "";

            string currentString2 = Form1.days[0].currentTime;
            DateTime hour2 = DateTime.Parse(currentString2);
            if (hour2.Minute > 0)
            {
                hour2 = hour2.AddMinutes(-hour2.Minute);
            }
            hour2 = hour2.AddMinutes(120);
            hourly2.Text = hour2 + "";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            Form1.ExtractCurrent();
            DisplayCurrent();
        }
    }
}