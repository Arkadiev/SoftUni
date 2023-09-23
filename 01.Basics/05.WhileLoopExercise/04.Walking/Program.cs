using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            bool goalIsReached = false;

            string input = Console.ReadLine();
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                totalSteps += steps;

                if (totalSteps >= 10000)
                {
                    goalIsReached = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (!goalIsReached)
            {
                int stepsGoingHome = int.Parse(Console.ReadLine());
                totalSteps += stepsGoingHome;
            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }

        }
    }
}
