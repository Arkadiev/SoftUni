using System;

namespace _02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            double capacity = 30000.00;
            double workdays = 365 - holidays;
            double playtime = (workdays * 63) + (holidays * 127);

            double playtimeTotal = Math.Abs(capacity - playtime);
            double playtimeHours = Math.Floor(playtimeTotal / 60);
            double playtimeMinutes = Math.Round(playtimeTotal % 60);

            if (capacity > playtime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{playtimeHours} hours and {playtimeMinutes} minutes less for play");
            }
            else if (capacity < playtime)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{playtimeHours} hours and {playtimeMinutes} minutes more for play");
            }
        }
    }
}
