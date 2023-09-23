using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string chr = Console.ReadLine();

            double result = 0.00;
            string evenOdd = "";

            if (chr == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else if (result % 2 != 0)
                {
                    evenOdd = "odd";
                }
                Console.WriteLine($"{num1} + {num2} = {result} - {evenOdd}");
            }
            else if (chr == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else if (result % 2 != 0)
                {
                    evenOdd = "odd";
                }
                Console.WriteLine($"{num1} - {num2} = {result} - {evenOdd}");
            }
            else if (chr == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else if (result % 2 != 0)
                {
                    evenOdd = "odd";
                }
                Console.WriteLine($"{num1} * {num2} = {result} - {evenOdd}");
            }
            else if (chr == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
            }
            else if (chr == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (num2 != 0)
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }
        }
    }
}
