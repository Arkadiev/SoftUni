using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 0; i < groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());

                if (climbers <= 5) { p1 += climbers; }
                else if (climbers >= 6 && climbers <= 12) { p2 += climbers; }
                else if (climbers >= 13 && climbers <= 25) { p3 += climbers; }
                else if (climbers >= 26 && climbers <= 40) { p4 += climbers; }
                else if (climbers >= 41) { p5 += climbers; }
            }

            int totalClimbers = p1 + p2 + p3 + p4 + p5;

            Console.WriteLine($"{(p1 * 100.0) / totalClimbers:f2}%");
            Console.WriteLine($"{(p2 * 100.0) / totalClimbers:f2}%");
            Console.WriteLine($"{(p3 * 100.0) / totalClimbers:f2}%");
            Console.WriteLine($"{(p4 * 100.0) / totalClimbers:f2}%");
            Console.WriteLine($"{(p5 * 100.0) / totalClimbers:f2}%");
        }
    }
}
