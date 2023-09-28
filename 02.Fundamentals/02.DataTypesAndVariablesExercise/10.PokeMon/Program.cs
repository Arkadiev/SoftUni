namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaust = int.Parse(Console.ReadLine());

            int targets = 0;
            double percent = (double)power * 0.5;

            while (power >= distance)
            {
                targets++;
                power -= distance;

                if (power == percent && distance != 0)
                {
                    power /= exhaust;
                }

            }

            Console.WriteLine(power);
            Console.WriteLine(targets);

        }
    }
}