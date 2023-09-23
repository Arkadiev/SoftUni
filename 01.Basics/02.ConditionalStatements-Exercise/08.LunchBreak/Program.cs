using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tvShow = (Console.ReadLine());
            int tvShowLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());

            double lunch = breakLenght * 0.125;
            double rest = breakLenght * 0.25;

            double totalFreeTime = breakLenght - lunch - rest;

            if (totalFreeTime >= tvShowLenght)
            {
                Console.WriteLine($"You have enough time to watch {tvShow} and left with {Math.Ceiling(totalFreeTime - tvShowLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {tvShow}, you need {Math.Ceiling(tvShowLenght - totalFreeTime)} more minutes.");
            }
        }
    }
}