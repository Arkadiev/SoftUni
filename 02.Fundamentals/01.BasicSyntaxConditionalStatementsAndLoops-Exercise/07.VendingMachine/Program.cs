namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double sum = 0;

            while (input != "Start")
            {
                input = Console.ReadLine();

                if (input == "Start") { break; }

                double coins = double.Parse(input);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }

            string input2 = "";

            while (input2 != "End")
            {
                input2 = Console.ReadLine();

                double price = 1.0;

                if (input2 == "End") { break; }
                if (input2 != "Nuts" && input2 != "Water" && input2 != "Crisps" && input2 != "Soda" && input2 != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else if (input2 == "Nuts")
                {
                    price = 2.0;
                    if (sum - price >= 0) { sum -= price; Console.WriteLine("Purchased nuts"); }
                    else { Console.WriteLine("Sorry, not enough money"); }
                }
                else if (input2 == "Water")
                {
                    price = 0.7;
                    if (sum - price >= 0) { sum -= price; Console.WriteLine("Purchased water"); }
                    else { Console.WriteLine("Sorry, not enough money"); }
                }
                else if (input2 == "Crisps")
                {
                    price = 1.5;
                    if (sum - price >= 0) { sum -= price; Console.WriteLine("Purchased crisps"); }
                    else { Console.WriteLine("Sorry, not enough money"); }
                }
                else if (input2 == "Soda")
                {
                    price = 0.8;
                    if (sum - price >= 0) { sum -= price; Console.WriteLine("Purchased soda"); }
                    else { Console.WriteLine("Sorry, not enough money"); }
                }
                else if (input2 == "Coke")
                {
                    price = 1.0;
                    if (sum - price >= 0) { sum -= price; Console.WriteLine("Purchased coke"); }
                    else { Console.WriteLine("Sorry, not enough money"); }
                }
            }

            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}