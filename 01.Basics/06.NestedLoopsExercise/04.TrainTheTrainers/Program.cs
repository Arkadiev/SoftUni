using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juriesCount = int.Parse(Console.ReadLine());

            int presentationsCount = 0;
            double totalGradesSum = 0;

            string presentation = Console.ReadLine();
            while (presentation != "Finish")
            {
                double sum = 0;
                for (int i = 0; i < juriesCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }

                double average = sum / juriesCount;
                Console.WriteLine($"{presentation} - {average:f2}.");

                presentationsCount++;
                totalGradesSum += sum;

                presentation = Console.ReadLine();
            }

            double finalAverage = totalGradesSum / (presentationsCount * juriesCount);
            Console.WriteLine($"Student's final assessment is {finalAverage:f2}.");
        }
    }
}
