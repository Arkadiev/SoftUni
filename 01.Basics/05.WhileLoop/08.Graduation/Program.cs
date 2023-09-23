using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumGrade = 0;
            int grade = 1;
            int badGrades = 0;

            string name = Console.ReadLine();
            
            while (grade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade < 4)
                {
                    badGrades++;

                    if (badGrades > 1)
                    {
                        break;
                    }

                    continue;
                }

                grade++;
                sumGrade += currentGrade;
            }

            if (badGrades > 1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double averageGrade = sumGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
