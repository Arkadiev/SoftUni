using System;

namespace _05.FifthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerGoals = 0;
            string bestPlayer = "";

            string player = Console.ReadLine();
            while (player != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > playerGoals)
                {
                    bestPlayer = player;
                    playerGoals = goals;
                }

                if (goals >= 10)
                {
                    break;
                }

                player = Console.ReadLine();
            }

            if (playerGoals >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {playerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {playerGoals} goals.");
            }


        }
    }
}
