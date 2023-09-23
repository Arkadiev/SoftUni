namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (group == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }

            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }

            else if (group == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double total = count * price;

            if (group == "Students" && count >= 30)
            {
                total *= 0.85;
            }

            if (group == "Business" && count >= 100)
            {
                total = (count - 10) * price;
            }

            if (group == "Regular" && count >= 10 && count <= 20)
            {
                total *= 0.95;
            }

            Console.WriteLine($"Total price: {total:f2}");

        }
    }
}