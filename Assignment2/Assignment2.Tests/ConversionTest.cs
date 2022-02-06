using System;
using NUnit.Framework;
using Assignment2;

namespace Assignment2.Tests
{
    public class ConversionTest
    {
        double result;
        [Test]
        public void ConvertCelciusToFahrenheitTest()
        {
            //arrange
            int userValue = 10;
            double expectedValue = 50;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertCelciusToFahrenheit();

            //assert
            Assert.AreEqual(expectedValue,result);

        }
        [Test]
        public void ConvertCelciusToFahrenheitTest1()
        {
            int userValue = 39;
            double expectedValue = 102.2;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertCelciusToFahrenheit();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTest2()
        {
            int userValue = 166;
            double expectedValue = 330.8;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertCelciusToFahrenheit();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertCelciusToKelvinTest()
        {
            int userValue = 1;
            double expectedValue = 274.15;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertCelciusToKelvin();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertCelciusToKelvinTest1()
        {
            int userValue = 44;
            double expectedValue = 317.15;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertCelciusToKelvin();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertCelciusToKelvinTest2()
        {
            int userValue = 166;
            double expectedValue = 439.15;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertCelciusToKelvin();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTest()
        {
            int userValue = 28;
            double expectedValue = -409.27;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertKelvinToFahrenheit();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTest1()
        {
            int userValue = 100;
            double expectedValue = -279.67;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertKelvinToFahrenheit();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTest2()
        {
            int userValue = 88;
            double expectedValue = -301.27;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertKelvinToFahrenheit();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertKelvinToCelsiusTest()
        {
            int userValue = 6;
            double expectedValue = -267.15;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertKelvinToCelsius();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertKelvinToCelsiusTest1()
        {
            int userValue = 68;
            double expectedValue = -205.15;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertKelvinToCelsius();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertKelvinToCelsiusTest2()
        {
            int userValue = 678;
            double expectedValue = 404.85;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertKelvinToCelsius();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTest()
        {
            int userValue = 4;
            double expectedValue = 257.594;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertFahrenheitToKelvin();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTest1()
        {
            int userValue = 57;
            double expectedValue = 287.039;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertFahrenheitToKelvin();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTest2()
        {
            int userValue = 67;
            double expectedValue = 292.594;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertFahrenheitToKelvin();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest()
        {
            int userValue = 455;
            double expectedValue = 235;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertFahrenheitToCelsius();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest1()
        {
            int userValue = 65;
            double expectedValue = 18.3333;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertFahrenheitToCelsius();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest2()
        {
            int userValue = 34;
            double expectedValue = 1.11111;
            var conversion = new Conversion(userValue);
            //act
            result = conversion.ConvertFahrenheitToCelsius();

            //assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
