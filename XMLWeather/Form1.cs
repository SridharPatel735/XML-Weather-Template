using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        public static string place = "stratford,ca";
        public static string Hour1Temp, Hour1Feels, Hour1Humibity, Hour2Temp, Hour2Feels, Hour2Humibity;

        public Form1()
        {

            InitializeComponent();
            ExtractForecast();
            ExtractCurrent();
            ExtractHourly();

            //open weather screen for todays weather
            CurrentScreen css = new CurrentScreen();
            this.Controls.Add(css);
        }

        public static void ExtractForecast()
        {
            string urlForecast = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + place + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            XmlReader reader = XmlReader.Create(urlForecast);

            while (reader.Read())
            {
                //create a day object
                Day d = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");
                
                //Get sunrise and sunset

                reader.ReadToFollowing("symbol");
                d.weatherNumber = reader.GetAttribute("number");
                d.condition = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                d.day = reader.GetAttribute("day");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");
                d.night = reader.GetAttribute("night");

                //TODO: if day object not null add to the days list
                days.Add(d);
            }
        }
        public static void ExtractCurrent()
        {
            string urlCurrent = "http://api.openweathermap.org/data/2.5/weather?q=" + place + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create(urlCurrent);

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            days[0].date = DateTime.Now.ToString("ddd dd MMMM");
            days[0].currentTime = DateTime.Now.ToString("hh:mm");

            reader.ReadToFollowing("sun");
            days[0].sunRise = reader.GetAttribute("rise");
            days[0].sunSet = reader.GetAttribute("set");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");

            reader.ReadToFollowing("feels_like");
            days[0].feelsLike = reader.GetAttribute("value");

            reader.ReadToFollowing("wind");
            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");
            days[0].wind = reader.GetAttribute("name");

            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("name");

            reader.ReadToFollowing("weather");
            days[0].weatherNumber = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");
        }
        public static void ExtractHourly()
        {
            string urlHourly = "http://api.openweathermap.org/data/2.5/forecast?q=" + place + "&mode=xml&units=metric&appid=4c8cc783408cdd4d9defadf565dc355a";
            XmlReader reader = XmlReader.Create(urlHourly);

            reader.ReadToFollowing("temperature");
            Hour1Temp = reader.GetAttribute("value");

            reader.ReadToFollowing("feels_like");
            Hour1Feels = reader.GetAttribute("value");

            reader.ReadToFollowing("humidity");
            Hour1Feels = reader.GetAttribute("value");

            reader.ReadToFollowing("temperature");
            Hour2Temp = reader.GetAttribute("value");

            reader.ReadToFollowing("feels_like");
            Hour2Feels = reader.GetAttribute("value");

            reader.ReadToFollowing("humidity");
            Hour2Feels = reader.GetAttribute("value");
        }
    }
}