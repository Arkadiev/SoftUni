namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double price = 0;

            if (kilometers >= 100)
            {
                price = kilometers * 0.06;
            }
            else if (kilometers >= 20)
            {
                price = kilometers * 0.09;
            }
            else if (kilometers < 20)
            {
                if (timeOfDay == "day")
                {
                    price = (kilometers * 0.79) + 0.7;
                }
                else if (timeOfDay == "night")
                {
                    price = (kilometers * 0.9) + 0.7;
                }
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}