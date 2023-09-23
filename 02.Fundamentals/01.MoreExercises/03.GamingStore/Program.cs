namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string input = "";
            double price = 0;
            double total = 0;

            while (input != "Game Time")
            {
                input = Console.ReadLine();

                if (input == "Game Time") { break; }

                else if (input != "OutFall 4" && input != "CS: OG" && input != "Zplinter Zell" && input != "Honored 2" && input != "RoverWatch" && input != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }
                else if (input == "OutFall 4")
                {
                    price = 39.99;
                    if (balance >= price)
                    {
                        balance -= price;
                        total += price;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "CS: OG")
                {
                    price = 15.99;
                    if (balance >= price)
                    {
                        balance -= price;
                        total += price;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    price = 19.99;
                    if (balance >= price)
                    {
                        balance -= price;
                        total += price;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "Honored 2")
                {
                    price = 59.99;
                    if (balance >= price)
                    {
                        balance -= price;
                        total += price;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch")
                {
                    price = 29.99;
                    if (balance >= price)
                    {
                        balance -= price;
                        total += price;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    if (balance >= price)
                    {
                        balance -= price;
                        total += price;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

            }

            if (balance != 0)
            {
                Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${balance:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }

        }
    }
}