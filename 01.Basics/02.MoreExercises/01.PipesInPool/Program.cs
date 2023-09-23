using System;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pool = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1Total = pipe1 * hours;
            double pipe2Total = pipe2 * hours;
            double pipesTotal = pipe1Total + pipe2Total;

            if (pool >= pipesTotal)
            {
                double pipe1Percentage = pipe1Total / pipesTotal * 100;
                double pipe2Percentage = pipe2Total / pipesTotal * 100;
                double poolPercentage = pipesTotal / pool * 100;
                Console.WriteLine($"The pool is {poolPercentage:f2}% full. Pipe 1: {pipe1Percentage:f2}%. Pipe 2: {pipe2Percentage:f2}%.");
            }
            else if (pipesTotal > pool)
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {pipesTotal - pool:f2} liters.");
            }
        }
    }
}
