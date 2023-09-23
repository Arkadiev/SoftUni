namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double finalPrice = 0;

            for (int i = 1; i <= orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double capsuleCount = double.Parse(Console.ReadLine());

                double total = ((days * capsuleCount) * capsulePrice);
                finalPrice += total;

                Console.WriteLine($"The price for the coffee is: ${total:f2}");
            }

            Console.WriteLine($"Total: ${finalPrice:f2}");

        }
    }
}