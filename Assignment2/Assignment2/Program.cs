using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.start();
        }

        void start()
        {
            string temperatureValueString = "";
            string switchOptionValue = "";
            int temperaturValueInt = 1;
            int switchOptionValueInt = 0;
        do 
        { 
            do
            {
                Console.Write("Please enter temperature value= ");
                temperatureValueString = Console.ReadLine();

                if (!(int.TryParse(temperatureValueString, out temperaturValueInt)) || temperaturValueInt <= 0)
                {
                    Console.WriteLine($"{temperatureValueString} is not a integer number or greater than 0");
                    Console.WriteLine("");
                }
            } while (!int.TryParse(temperatureValueString, out temperaturValueInt) || temperaturValueInt <= 0);

            Conversion conversion = new Conversion(temperaturValueInt);
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Select conversion option");
                    Console.WriteLine("1. Convert Celsius to Fahrenheit");
                    Console.WriteLine("2. Convert Celsius to Kelvin");
                    Console.WriteLine("3. Convert Fahrenheit to Celsius");
                    Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                    Console.WriteLine("5. Convert Kelvin to Celsius");
                    Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                    Console.WriteLine("7. Exit");
                    Console.Write("Enter Option Number= ");
                    switchOptionValue = Console.ReadLine();

                } while (!int.TryParse(switchOptionValue, out switchOptionValueInt) || (switchOptionValueInt <= 0 || switchOptionValueInt > 7));

                switch (switchOptionValueInt)
                {
                    case 1:
                        Console.WriteLine($"Temperature is {conversion.ConvertCelciusToFahrenheit()}F");
                        break;

                    case 2:
                        Console.WriteLine($"Temperature is {conversion.ConvertCelciusToKelvin()}K");
                        break;

                    case 3:
                        Console.WriteLine($"Temperature is {conversion.ConvertFahrenheitToCelsius()}C");
                        break;

                    case 4:
                        Console.WriteLine($"Temperature is {conversion.ConvertFahrenheitToKelvin()}K");
                        break;

                    case 5:
                        Console.WriteLine($"Temperature is {conversion.ConvertKelvinToCelsius()}C");
                        break;

                    case 6:
                        Console.WriteLine($"Temperature is {conversion.ConvertKelvinToFahrenheit()}F");
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("System Error please try again");
                        break;
                }
                Console.WriteLine("");
            } while (true);
        }
    }
}
