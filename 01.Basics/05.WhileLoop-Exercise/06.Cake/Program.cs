using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int totalCakePieces = width * lenght;

            string input = Console.ReadLine();
            while (input != "STOP")
            {
                int piecesToSubstract = int.Parse(input);
                totalCakePieces -= piecesToSubstract;
                if (totalCakePieces < 0)
                {
                    break;
                }


                input = Console.ReadLine();
            }

            if (totalCakePieces >= 0)
            {
                Console.WriteLine($"{totalCakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalCakePieces)} pieces more.");
            }    
        }
    }
}
