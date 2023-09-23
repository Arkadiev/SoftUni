using System;

namespace _10.WeatherForecastPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            string weather = "";

            if (degrees >= 26 && degrees <= 35) weather = "Hot";
            else if (degrees >= 20.1 && degrees <= 25.9) weather = "Warm";
            else if (degrees >= 15 && degrees <= 20) weather = "Mild";
            else if (degrees >= 12 & degrees <= 14.9) weather = "Cool";
            else if (degrees >= 5 && degrees <= 11.9) weather = "Cold";
            else weather = "unknown";

            Console.WriteLine(weather);
        }
    }
}
