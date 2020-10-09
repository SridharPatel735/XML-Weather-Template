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
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            dateTimeLabel.Text = Form1.days[0].date + " " + Form1.days[0].currentTime;
            double currentTemp = Convert.ToDouble(Form1.days[0].currentTemp);
            tempLabel.Text = currentTemp.ToString("##") + "\u00B0";

            double minTemp = Convert.ToDouble(Form1.days[0].tempLow);
            tempLabel.Text = currentTemp.ToString("##") + "\u00B0";
            double maxTemp = Convert.ToDouble(Form1.days[0].tempHigh);
            tempLabel.Text = currentTemp.ToString("##") + "\u00B0";
            minMaxOutput.Text = maxTemp.ToString("##") + "\u00B0" + "/" + minTemp.ToString("##") + "\u00B0";

            double feelsTemp = Convert.ToDouble(Form1.days[0].feelsLike);
            feelsLikeLabel.Text = "Feels Like: " + feelsTemp.ToString("##") + "\u00B0";
            conditionLabel.Text = Form1.days[0].condition;
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
