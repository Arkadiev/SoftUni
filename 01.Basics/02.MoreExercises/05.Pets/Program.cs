namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double totalNeededFood = (days * dogFood) + (days * catFood) + (days * turtleFood / 1000);


            if (food >= totalNeededFood)
            {
                Console.WriteLine($"{Math.Floor(food - totalNeededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalNeededFood - food)} more kilos of food are needed.");
            }

        }
    }
}