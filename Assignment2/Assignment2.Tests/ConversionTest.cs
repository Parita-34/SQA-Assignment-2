using System;
using NUnit.Framework;
using Assignment2;

namespace Assignment2.Tests
{
    public class ConversionTest
    {
        double output;
        [Test]
        public void ConvertCelciusToFahrenheitTest()
        {
            //Arrange
            int userValue = 10;
            double expectedValue = 50;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(expectedValue,output);

        }
        [Test]
        public void ConvertCelciusToFahrenheitTest1()
        {
            //Arrange
            int userValue = 39;
            double expectedValue = 102.2;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTest2()
        {
            int userValue = 166;
            double expectedValue = 330.8;
            var conversion = new Conversion(userValue);
            //act
            output = conversion.ConvertCelciusToFahrenheit();

            //assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertCelciusToKelvinTest()
        {
            //Arrange
            int userValue = 1;
            double expectedValue = 274.15;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertCelciusToKelvinTest1()
        {
            int userValue = 44;
            double expectedValue = 317.15;
            var conversion = new Conversion(userValue);
            //act
            output = conversion.ConvertCelciusToKelvin();

            //assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertCelciusToKelvinTest2()
        {
            //Arrange
            int userValue = 166;
            double expectedValue = 439.15;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTest()
        {
            //Arrange
            int userValue = 28;
            double expectedValue = -409.27;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTest1()
        {
            //Arrange
            int userValue = 100;
            double expectedValue = -279.67;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTest2()
        {
            //Arrange
            int userValue = 88;
            double expectedValue = -301.27;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertKelvinToCelsiusTest()
        {
            //Arrange
            int userValue = 6;
            double expectedValue = -267.15;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertKelvinToCelsiusTest1()
        {
            //Arrange
            int userValue = 68;
            double expectedValue = -205.15;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertKelvinToCelsiusTest2()
        {
            //Arrange
            int userValue = 678;
            double expectedValue = 404.85;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTest()
        {
            //Arrange
            int userValue = 4;
            double expectedValue = 257.59;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTest1()
        {
            //Arrange
            int userValue = 57;
            double expectedValue = 287.04;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTest2()
        {
            //Arrange
            int userValue = 67;
            double expectedValue = 292.59;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest()
        {
            //Arrange
            int userValue = 455;
            double expectedValue = 235;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest1()
        {
            //Arrange
            int userValue = 65;
            double expectedValue = 18.33;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTest2()
        {
            //Arrange
            int userValue = 34;
            double expectedValue = 1.11;
            var conversion = new Conversion(userValue);
            //Act
            output = conversion.ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(expectedValue, output);
        }
    }
}
