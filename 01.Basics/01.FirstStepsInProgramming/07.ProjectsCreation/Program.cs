using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int totalProjects = int.Parse(Console.ReadLine());

            int projectTime = 3;
            int totalHours = totalProjects * projectTime;

            Console.WriteLine($"The architect {archName} will need {totalHours} hours to complete {totalProjects} project/s.");
        }
    }
}
