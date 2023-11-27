using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            decimal totalSum = 0;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal totalPrice = quantity * price;
                    totalSum += totalPrice;

                    Console.Write($"{customer}: {product} - {totalPrice:f2}\n");
                }
            }

            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}