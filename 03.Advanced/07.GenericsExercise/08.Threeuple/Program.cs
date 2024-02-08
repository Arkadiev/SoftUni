using System.Globalization;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] beerTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] bankTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string townName;
            if (nameTokens.Length == 5)
            {
                townName = $"{nameTokens[3]} {nameTokens[4]}";
            }
            else
            {
                townName = nameTokens[3];
            }

            Threeuple<string, string, string> names = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2], townName);
            Threeuple<string, int, bool> beers = new(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");
            Threeuple<string, double, string> banks = new(bankTokens[0], double.Parse(bankTokens[1], CultureInfo.InvariantCulture), bankTokens[2]);


            Console.WriteLine(names.ToString());
            Console.WriteLine(beers.ToString());
            Console.WriteLine(banks.ToString());
        }
    }
}