namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int result = 0;

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int water = int.Parse(Console.ReadLine());

                if (water <= capacity)
                {
                    capacity -= water;
                    result += water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(result);

        }
    }
}