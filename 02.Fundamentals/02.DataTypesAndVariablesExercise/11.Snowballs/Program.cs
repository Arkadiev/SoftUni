namespace _11.Snowballs
{
    using System;
    using System.Numerics;
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int bestSize = 0;
            int bestTime = 0;
            int bestQuality = 0;

            BigInteger bestValue = 0;

            for (int i = 1; i <= count; i++)
            {
                int size = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(size / time, quality);

                if (value > bestValue)
                {
                    bestSize = size;
                    bestTime = time;
                    bestQuality = quality;
                    bestValue = value;
                }
            }

            Console.WriteLine($"{bestSize} : {bestTime} = {bestValue} ({bestQuality})");

        }
    }
}