using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0, nonPrimeSum = 0;
            
            string input = Console.ReadLine();
            while (input != "stop")
            {
                int num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    if (num < 2)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        double sqrt = Math.Sqrt(num);
                        for (int i = 2; i <= sqrt; i++)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }

                    if (isPrime) { primeSum += num; }
                    else { nonPrimeSum += num; }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
