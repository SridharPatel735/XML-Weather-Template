﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, day, night, condition, location, tempHigh, tempLow, wind, windDirection, windSpeed, weatherNumber, sunRise, sunSet, precipitation, visibility, feelsLike;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow = wind = windSpeed = weatherNumber = sunRise = sunSet = windDirection = precipitation = visibility = "";
        }
    }
}
