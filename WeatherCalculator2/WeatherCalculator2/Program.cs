using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            int RelativeHumidity;
            double windChill;
            double heatIndex;
            string input = "";
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);

            if (temperature > 49.9)
            {
                Console.WriteLine("Enter the Humidity");
                input = Console.ReadLine();
                RelativeHumidity = int.Parse(input);
                heatIndex = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + RelativeHumidity * 0.094);
                Console.WriteLine("The Heat Index is " + heatIndex);

            }
            else
            {
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);

            }
      

        }
    }
}
