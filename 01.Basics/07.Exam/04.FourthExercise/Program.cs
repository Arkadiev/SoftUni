using System;

namespace _04.FourthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            double s1 = 0, s2 = 0, s3 = 0, s4 = 0;

            double resultTotal = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                double result = double.Parse(Console.ReadLine());
                if (result >= 5.00)
                {
                    s1++;
                }
                else if (result >= 4 && result <= 4.99)
                {
                    s2++;
                }
                else if (result >= 3 && result <= 3.99)
                {
                    s3++;
                }
                else if (result < 3)
                {
                    s4++;
                }
                resultTotal += result;
            }

            double resultAverage = resultTotal / studentsCount;

            double s1percentage = s1 / studentsCount * 100;

            Console.WriteLine($"Top students: {s1 / studentsCount * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {s2 / studentsCount * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {s3 / studentsCount * 100:f2}%");
            Console.WriteLine($"Fail: {s4 / studentsCount * 100:f2}%");
            Console.WriteLine($"Average: {resultAverage:f2}");

        }
    }
}
