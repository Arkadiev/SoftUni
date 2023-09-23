using System;

namespace _03.ThirdExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            days--;
            double totalPrice = 0;

            if (roomType == "room for one person")
            {
                totalPrice = days * 18.00;
            }
            else if (roomType == "apartment")
            {
                totalPrice = days * 25.00;
                if (days < 10)
                {
                    totalPrice *= 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice *= 0.65;
                }
                else if (days > 15)
                {
                    totalPrice *= 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                totalPrice = days * 35.00;
                if (days < 10)
                {
                    totalPrice *= 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice *= 0.85;
                }
                else if (days > 15)
                {
                    totalPrice *= 0.8;
                }
            }

            if (feedback == "positive")
            {
                totalPrice = totalPrice + (totalPrice * 0.25);
            }
            else if (feedback == "negative")
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
