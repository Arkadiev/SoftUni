using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double secondsTotal = meters * secondsPerMeter;
            double slowness = Math.Floor(meters / 15) * 12.5;
            double timeTotal = secondsTotal + slowness;

            if (timeTotal < currentRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeTotal:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(currentRecord - timeTotal):f2} seconds slower.");
            }
        }
    }
}
