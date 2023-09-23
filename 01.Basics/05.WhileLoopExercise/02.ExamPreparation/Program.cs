using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxBadGradesCount = int.Parse(Console.ReadLine());

            int badGradesCount = 0, gradesSum = 0, problemsCount = 0;
            string lastProblemName = "";
            bool failed = false;

            string input = Console.ReadLine();
            while (input != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());

                problemsCount++;
                gradesSum += grade;
                lastProblemName = input;

                if (grade <= 4)
                {
                    badGradesCount++;
                    if (badGradesCount == maxBadGradesCount)
                    {
                        failed = true;
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            if (!failed)
            {
                Console.WriteLine($"Average score: {(gradesSum * 1.0) / problemsCount:F2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }

        }
    }
}
