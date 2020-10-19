using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            Day1();

            Day2();

            Day3();

            Day4();

            Day5();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            Form1.ExtractForecast();
            displayForecast();
        }

        private void Day1()
        {
            #region Current Date
            string currentString = Form1.days[1].date;
            DateTime day = DateTime.Parse(currentString);
            string dayDisplay;
            dayDisplay = day.ToString("ddd dd MMMM", DateTimeFormatInfo.InvariantInfo);
            date1Label.Text = dayDisplay;
            #endregion

            //Change background color depending on the time of day and weather
            double weatherNum = Convert.ToDouble(Form1.days[1].weatherNumber);
            if (weatherNum >= 200 && weatherNum <= 232)
            {
                day1Image.BackgroundImage = Properties.Resources._11n;
            }
            else if ((weatherNum >= 300 && weatherNum <= 321) || (weatherNum >= 520 && weatherNum <= 531))
            {
                day1Image.BackgroundImage = Properties.Resources._09n;
            }
            else if (weatherNum >= 500 && weatherNum <= 504)
            {
                day1Image.BackgroundImage = Properties.Resources._10d;
            }
            else if ((weatherNum == 511) || (weatherNum >= 600 && weatherNum <= 622))
            {
                day1Image.BackgroundImage = Properties.Resources._13d;
            }
            else if (weatherNum >= 701 && weatherNum <= 781)
            {
                day1Image.BackgroundImage = Properties.Resources._50n;
            }
            else if (weatherNum == 800)
            {
                day1Image.BackgroundImage = Properties.Resources._01d;
            }
            else if (weatherNum == 801)
            {
                day1Image.BackgroundImage = Properties.Resources._02d;
            }
            else if (weatherNum == 802)
            {
                day1Image.BackgroundImage = Properties.Resources._03d;
            }
            else if (weatherNum == 803 || weatherNum == 804)
            {
                day1Image.BackgroundImage = Properties.Resources._04n;
            }

            conditionLabel1.Text = Form1.days[1].condition;
            double minTemp = Convert.ToDouble(Form1.days[1].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[1].tempHigh);
            double dayTemp = Convert.ToDouble(Form1.days[1].day);
            double night = Convert.ToDouble(Form1.days[1].night);
            minMaxDayNightLabel1.Text = "Max:" + maxTemp.ToString("##") + "\u00B0" + " Min:" + minTemp.ToString("##") + "\u00B0" + " Day:" + dayTemp.ToString("##") + "\u00B0" + " Night:" + night.ToString("##") + "\u00B0";
        }

        private void Day2()
        {
            string currentString = Form1.days[2].date;
            DateTime day = DateTime.Parse(currentString);
            string dayDisplay;
            dayDisplay = day.ToString("ddd dd MMMM", DateTimeFormatInfo.InvariantInfo);
            date2Label.Text = dayDisplay;

            //Change background color depending on the time of day and weather
            double weatherNum = Convert.ToDouble(Form1.days[2].weatherNumber);
            if (weatherNum >= 200 && weatherNum <= 232)
            {
                day2Image.BackgroundImage = Properties.Resources._11n;
            }
            else if ((weatherNum >= 300 && weatherNum <= 321) || (weatherNum >= 520 && weatherNum <= 531))
            {
                day2Image.BackgroundImage = Properties.Resources._09n;
            }
            else if (weatherNum >= 500 && weatherNum <= 504)
            {
                day2Image.BackgroundImage = Properties.Resources._10d;
            }
            else if ((weatherNum == 511) || (weatherNum >= 600 && weatherNum <= 622))
            {
                day2Image.BackgroundImage = Properties.Resources._13d;
            }
            else if (weatherNum >= 701 && weatherNum <= 781)
            {
                day2Image.BackgroundImage = Properties.Resources._50n;
            }
            else if (weatherNum == 800)
            {
                day2Image.BackgroundImage = Properties.Resources._01d;
            }
            else if (weatherNum == 801)
            {
                day2Image.BackgroundImage = Properties.Resources._02d;
            }
            else if (weatherNum == 802)
            {
                day2Image.BackgroundImage = Properties.Resources._03d;
            }
            else if (weatherNum == 803 || weatherNum == 804)
            {
                day2Image.BackgroundImage = Properties.Resources._04n;
            }

            conditionLabel2.Text = Form1.days[2].condition;
            double minTemp = Convert.ToDouble(Form1.days[2].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[2].tempHigh);
            double dayTemp = Convert.ToDouble(Form1.days[2].day);
            double night = Convert.ToDouble(Form1.days[2].night);
            minMaxDayNightLabel2.Text = "Max:" + maxTemp.ToString("##") + "\u00B0" + " Min:" + minTemp.ToString("##") + "\u00B0" + " Day:" + dayTemp.ToString("##") + "\u00B0" + " Night:" + night.ToString("##") + "\u00B0";
        }

        private void Day3()
        {
            string currentString = Form1.days[3].date;
            DateTime day = DateTime.Parse(currentString);
            string dayDisplay;
            dayDisplay = day.ToString("ddd dd MMMM", DateTimeFormatInfo.InvariantInfo);
            date3Label.Text = dayDisplay;

            //Change background color depending on the time of day and weather
            double weatherNum = Convert.ToDouble(Form1.days[3].weatherNumber);
            if (weatherNum >= 200 && weatherNum <= 232)
            {
                day3Image.BackgroundImage = Properties.Resources._11n;
            }
            else if ((weatherNum >= 300 && weatherNum <= 321) || (weatherNum >= 520 && weatherNum <= 531))
            {
                day3Image.BackgroundImage = Properties.Resources._09n;
            }
            else if (weatherNum >= 500 && weatherNum <= 504)
            {
                day3Image.BackgroundImage = Properties.Resources._10d;
            }
            else if ((weatherNum == 511) || (weatherNum >= 600 && weatherNum <= 622))
            {
                day3Image.BackgroundImage = Properties.Resources._13d;
            }
            else if (weatherNum >= 701 && weatherNum <= 781)
            {
                day3Image.BackgroundImage = Properties.Resources._50n;
            }
            else if (weatherNum == 800)
            {
                day3Image.BackgroundImage = Properties.Resources._01d;
            }
            else if (weatherNum == 801)
            {
                day3Image.BackgroundImage = Properties.Resources._02d;
            }
            else if (weatherNum == 802)
            {
                day3Image.BackgroundImage = Properties.Resources._03d;
            }
            else if (weatherNum == 803 || weatherNum == 804)
            {
                day3Image.BackgroundImage = Properties.Resources._04n;
            }

            conditionLabel3.Text = Form1.days[3].condition;
            double minTemp = Convert.ToDouble(Form1.days[3].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[3].tempHigh);
            double dayTemp = Convert.ToDouble(Form1.days[3].day);
            double night = Convert.ToDouble(Form1.days[3].night);
            minMaxDayNightLabel3.Text = "Max:" + maxTemp.ToString("##") + "\u00B0" + " Min:" + minTemp.ToString("##") + "\u00B0" + " Day:" + dayTemp.ToString("##") + "\u00B0" + " Night:" + night.ToString("##") + "\u00B0";
        }

        private void Day4()
        {
            string currentString = Form1.days[4].date;
            DateTime day = DateTime.Parse(currentString);
            string dayDisplay;
            dayDisplay = day.ToString("ddd dd MMMM", DateTimeFormatInfo.InvariantInfo);
            date4Label.Text = dayDisplay;

            //Change background color depending on the time of day and weather
            double weatherNum = Convert.ToDouble(Form1.days[4].weatherNumber);
            if (weatherNum >= 200 && weatherNum <= 232)
            {
                day4Image.BackgroundImage = Properties.Resources._11n;
            }
            else if ((weatherNum >= 300 && weatherNum <= 321) || (weatherNum >= 520 && weatherNum <= 531))
            {
                day4Image.BackgroundImage = Properties.Resources._09n;
            }
            else if (weatherNum >= 500 && weatherNum <= 504)
            {
                day4Image.BackgroundImage = Properties.Resources._10d;
            }
            else if ((weatherNum == 511) || (weatherNum >= 600 && weatherNum <= 622))
            {
                day4Image.BackgroundImage = Properties.Resources._13d;
            }
            else if (weatherNum >= 701 && weatherNum <= 781)
            {
                day4Image.BackgroundImage = Properties.Resources._50n;
            }
            else if (weatherNum == 800)
            {
                day4Image.BackgroundImage = Properties.Resources._01d;
            }
            else if (weatherNum == 801)
            {
                day4Image.BackgroundImage = Properties.Resources._02d;
            }
            else if (weatherNum == 802)
            {
                day4Image.BackgroundImage = Properties.Resources._03d;
            }
            else if (weatherNum == 803 || weatherNum == 804)
            {
                day4Image.BackgroundImage = Properties.Resources._04n;
            }

            conditionLabel4.Text = Form1.days[4].condition;
            double minTemp = Convert.ToDouble(Form1.days[4].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[4].tempHigh);
            double dayTemp = Convert.ToDouble(Form1.days[4].day);
            double night = Convert.ToDouble(Form1.days[4].night);
            minMaxDayNightLabel4.Text = "Max:" + maxTemp.ToString("##") + "\u00B0" + " Min:" + minTemp.ToString("##") + "\u00B0" + " Day:" + dayTemp.ToString("##") + "\u00B0" + " Night:" + night.ToString("##") + "\u00B0";
        }

        private void Day5()
        {
            string currentString = Form1.days[5].date;
            DateTime day = DateTime.Parse(currentString);
            string dayDisplay;
            dayDisplay = day.ToString("ddd dd MMMM", DateTimeFormatInfo.InvariantInfo);
            date5Label.Text = dayDisplay;

            //Change background color depending on the time of day and weather
            double weatherNum = Convert.ToDouble(Form1.days[5].weatherNumber);
            if (weatherNum >= 200 && weatherNum <= 232)
            {
                day5Image.BackgroundImage = Properties.Resources._11n;
            }
            else if ((weatherNum >= 300 && weatherNum <= 321) || (weatherNum >= 520 && weatherNum <= 531))
            {
                day5Image.BackgroundImage = Properties.Resources._09n;
            }
            else if (weatherNum >= 500 && weatherNum <= 504)
            {
                day5Image.BackgroundImage = Properties.Resources._10d;
            }
            else if ((weatherNum == 511) || (weatherNum >= 600 && weatherNum <= 622))
            {
                day5Image.BackgroundImage = Properties.Resources._13d;
            }
            else if (weatherNum >= 701 && weatherNum <= 781)
            {
                day5Image.BackgroundImage = Properties.Resources._50n;
            }
            else if (weatherNum == 800)
            {
                day5Image.BackgroundImage = Properties.Resources._01d;
            }
            else if (weatherNum == 801)
            {
                day5Image.BackgroundImage = Properties.Resources._02d;
            }
            else if (weatherNum == 802)
            {
                day5Image.BackgroundImage = Properties.Resources._03d;
            }
            else if (weatherNum == 803 || weatherNum == 804)
            {
                day5Image.BackgroundImage = Properties.Resources._04n;
            }

            conditionLabel5.Text = Form1.days[5].condition;
            double minTemp = Convert.ToDouble(Form1.days[5].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[5].tempHigh);
            double dayTemp = Convert.ToDouble(Form1.days[5].day);
            double night = Convert.ToDouble(Form1.days[5].night);
            minMaxDayNightLabel5.Text = "Max:" + maxTemp.ToString("##") + "\u00B0" + " Min:" + minTemp.ToString("##") + "\u00B0" + " Day:" + dayTemp.ToString("##") + "\u00B0" + " Night:" + night.ToString("##") + "\u00B0";
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CitySelect cs = new CitySelect();
            f.Controls.Add(cs);
        }
    }
}