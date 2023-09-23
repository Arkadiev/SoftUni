using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;
            double totalPrice = 0;

            if (roomType == "room for one person")
            {
                totalPrice = nights * 18;
            }
            else if (roomType == "apartment")
            {
                totalPrice = nights * 25;
                if (days < 10) totalPrice *= 0.7;
                else if (nights >= 10 && nights <= 15) totalPrice *= 0.65;
                else if (nights > 15) totalPrice *= 0.5;
            }
            else if (roomType == "president apartment")
            {
                totalPrice = nights * 35;
                if (nights < 10) totalPrice *= 0.9;
                else if (nights >= 10 && nights <= 15) totalPrice *= 0.85;
                else if (nights > 15) totalPrice *= 0.8;
            }

            if (feedback == "positive")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }
            else if (feedback == "negative")
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
