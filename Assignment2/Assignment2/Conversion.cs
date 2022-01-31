using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Conversion
    {
        private int userValue;

        public Conversion()
        {
            userValue = 1;
        }

        public Conversion(int value)
        {
            userValue = value;
        }
        public double ConvertCelciusToFahrenheit()
        {
            return (userValue * 9 / 5) + 32;
        }

        public double ConvertCelciusToKelvin()
        {
            return userValue + 273.15;
        }

        public double ConvertKelvinToFahrenheit()
        {
            return (userValue - 273.15) * 9 / 5 + 32;
        }

        public double ConvertKelvinToCelsius()
        {
            return userValue - 273.15;
        }

        public double ConvertFahrenheitToKelvin()
        {
            return (userValue - 32) * 5 / 9 + 273.15;
        }

        public double ConvertFahrenheitToCelsius()
        {
            return (userValue - 32) * 5 / 9;
        }
    }
}
