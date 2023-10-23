namespace _02.SpaceTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] route = Console.ReadLine().Split("||").ToArray();

            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());


            for (int i = 0; i < route.Length; i++)
            {

                if (route[i] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }

                string[] arguments = route[i].Split();
                string command = arguments[0];
                int amount = int.Parse(arguments[1]);
                
                if (command == "Travel")
                {
                    if (fuel >= amount)
                    {
                        fuel -= amount;
                        Console.WriteLine($"The spaceship travelled {amount} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }

                if (command == "Enemy")
                {
                    if (ammunition >= amount)
                    {
                        ammunition -= amount;
                        Console.WriteLine($"An enemy with {amount} armour is defeated.");
                    }
                    else if (ammunition < amount && fuel >= amount * 2)
                    {
                        fuel -= amount * 2;
                        Console.WriteLine($"An enemy with {amount} armour is outmaneuvered.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }

                if (command == "Repair")
                {
                    fuel += amount;
                    ammunition += amount * 2;
                    Console.WriteLine($"Ammunitions added: {amount * 2}.");
                    Console.WriteLine($"Fuel added: {amount}.");
                }

            }
            

        }
    }
}