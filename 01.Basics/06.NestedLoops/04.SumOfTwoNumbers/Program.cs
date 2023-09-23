using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;

            bool isFound = false;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    counter++;

                    int sum = i + j;

                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {sum})");

                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
