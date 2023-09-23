using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = width * lenght * height;
            int postArea = area;
            int boxesTotal = 0;

            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                postArea -= boxes;
                boxesTotal += boxes;

                if (postArea < 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (postArea < 0)
            {
                Console.WriteLine($"No more free space! You need {boxesTotal - area} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{area - boxesTotal} Cubic meters left.");
            }
        }
    }
}
