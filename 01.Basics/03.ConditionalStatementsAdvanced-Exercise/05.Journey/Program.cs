using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string accomodation = "";
            double totalPrice = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    totalPrice = budget * 0.3;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    totalPrice = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    totalPrice = budget * 0.4;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    totalPrice = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                accomodation = "Hotel";
                totalPrice = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {totalPrice:f2}");
        }
    }
}
