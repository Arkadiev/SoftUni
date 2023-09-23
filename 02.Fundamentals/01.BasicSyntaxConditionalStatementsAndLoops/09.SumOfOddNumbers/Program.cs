namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= amount; i++)
            {
                int num = i * 2 - 1;
                Console.WriteLine(num);
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}