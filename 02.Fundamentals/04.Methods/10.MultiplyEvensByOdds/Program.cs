using System.Globalization;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = Result(number);
            Console.WriteLine(result);

            static int Result(int number)
            {
                int result = EvenSum(number) * OddSum(number);
                return result;
            }

            static int EvenSum (int number)
            {
                int evenSum = 0;
                while (number != 0)
                {
                    int nextNum = number % 10;
                    if (nextNum % 2 == 0)
                    {
                        evenSum += nextNum;
                    }
                    number -= nextNum;
                    number /= 10;
                }
                return evenSum;
            }

            static int OddSum(int number)
            {
                int oddSum = 0;
                while (number != 0)
                {
                    int nextNum = number % 10;
                    if (nextNum % 2 != 0)
                    {
                        oddSum += nextNum;
                    }
                    number -= nextNum;
                    number /= 10;
                }
                return oddSum;
            }
        }
    }
}