namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flower1 = int.Parse(Console.ReadLine());
            int flower2 = int.Parse(Console.ReadLine());
            int flower3 = int.Parse(Console.ReadLine());
            int flower4 = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double flower1Price = 3.25;
            double flower2Price = 4.0;
            double flower3Price = 3.5;
            double flower4Price = 8.0;

            double total = (flower1 * flower1Price) + (flower2 * flower2Price) + (flower3 * flower3Price) + (flower4 * flower4Price);
            double totalAfterTax = total * 0.95;

            if (total >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalAfterTax - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalAfterTax)} leva.");
            }

        }
    }
}