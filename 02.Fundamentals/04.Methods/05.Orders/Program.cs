namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            Price(product, amount);
        }

        static void Price(string product, double amount)
        {
            double price = 0;

            if (product == "coffee")
            {
                price = amount * 1.50;
            }

            else if (product == "water")
            {
                price = amount * 1.00;
            }

            else if (product == "coke")
            {
                price = amount * 1.40;
            }

            else if (product == "snacks")
            {
                price = amount * 2.00;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}