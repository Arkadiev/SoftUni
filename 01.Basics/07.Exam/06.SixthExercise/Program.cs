using System;

namespace _06.SixthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int num1 = num % 1000; num1 /= 100;
            int num2 = num % 100; num2 /= 10;
            int num3 = num % 10;

            for (int i = 1; i <= num3; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    for(int k = 1; k <= num1; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }

        }
    }
}
