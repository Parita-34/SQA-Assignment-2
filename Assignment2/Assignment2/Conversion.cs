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
            Console.WriteLine($"C: ${(39.90 * 9 / 5) + 32}");
            return Math.Round((Convert.ToDouble(userValue) * 9 / 5) + 32,2);
        }

        public double ConvertCelciusToKelvin()
        {
            return Math.Round(Convert.ToDouble(userValue) + 273.15,2);
        }

        public double ConvertKelvinToFahrenheit()
        {
            return Math.Round((Convert.ToDouble(userValue) - 273.15) * 9 / 5 + 32,2);
        }

        public double ConvertKelvinToCelsius()
        {
            return Math.Round(Convert.ToDouble(userValue) - 273.15,2);
        }

        public double ConvertFahrenheitToKelvin()
        {
            return Math.Round((Convert.ToDouble(userValue) - 32) * 5 / 9 + 273.15,2);
        }

        public double ConvertFahrenheitToCelsius()
        {
            return Math.Round((Convert.ToDouble(userValue) - 32) * 5 / 9,2);
        }
    }
}
