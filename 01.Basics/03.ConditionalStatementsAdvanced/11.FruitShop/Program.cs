using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{amount * 2.5:f2}"); break;
                    case "apple": Console.WriteLine($"{amount * 1.2:f2}"); break;
                    case "orange": Console.WriteLine($"{amount * 0.85:f2}"); break;
                    case "grapefruit": Console.WriteLine($"{amount * 1.45:f2}"); break;
                    case "kiwi": Console.WriteLine($"{amount * 2.7:f2}"); break;
                    case "pineapple": Console.WriteLine($"{amount * 5.5:f2}"); break;
                    case "grapes": Console.WriteLine($"{amount * 3.85:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{amount * 2.7:f2}"); break;
                    case "apple": Console.WriteLine($"{amount * 1.25:f2}"); break;
                    case "orange": Console.WriteLine($"{amount * 0.9:f2}"); break;
                    case "grapefruit": Console.WriteLine($"{amount * 1.6:f2}"); break;
                    case "kiwi": Console.WriteLine($"{amount * 3:f2}"); break;
                    case "pineapple": Console.WriteLine($"{amount * 5.6:f2}"); break;
                    case "grapes": Console.WriteLine($"{amount * 4.2:f2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
