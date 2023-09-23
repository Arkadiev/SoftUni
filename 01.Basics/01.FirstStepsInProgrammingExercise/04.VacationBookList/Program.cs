using System;

namespace _04.VacationBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesCurrentBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysNeeded = int.Parse(Console.ReadLine());

            double hoursPerDay = (pagesCurrentBook / pagesPerHour) / daysNeeded;

            Console.WriteLine(hoursPerDay);
        }
    }
}
