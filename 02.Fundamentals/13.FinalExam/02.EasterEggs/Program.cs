// @"@@@green@*/10/@ye10w@*26*#red#####//8//@limon*@*23*@@@red#*/%^&/6/@gree_een@/notnumber/###purple@@@@@*$%^&*/5/

using System.Text.RegularExpressions;

namespace _02.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([@#]+)(?'color'[a-z]{3,})([@#*])([^\w\d]*)(\/)(?'amount'\d+)(\/)";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string color = match.Groups["color"].Value;
                int amount = int.Parse(match.Groups["amount"].Value);

                Console.WriteLine($"You found {amount} {color} eggs!");
            }
        }
    }
}