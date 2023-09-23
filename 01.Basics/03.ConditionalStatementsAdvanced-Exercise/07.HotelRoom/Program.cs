using System;
using System.Reflection.Metadata;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            if (month == "May" || month == "October")
            {
                apartmentPrice = 65;
                studioPrice = 50;
            }
            else if (month == "June" || month == "September")
            {
                apartmentPrice = 68.7;
                studioPrice = 75.2;
            }
            else if (month == "July" || month == "August")
            {
                apartmentPrice = 77;
                studioPrice = 76;
            }

            double totalApartmentPrice = apartmentPrice * nights;
            double totalStudioPrice = studioPrice * nights;

            if (month == "May" || month == "October")
            {
                if (nights > 14)
                {
                    totalStudioPrice *= 0.7;
                }
                else if (nights > 7)
                {
                    totalStudioPrice *= 0.95;
                }
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                totalStudioPrice *= 0.8;
            }

            if (nights > 14)
            {
                totalApartmentPrice *= 0.9;
            }

            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
