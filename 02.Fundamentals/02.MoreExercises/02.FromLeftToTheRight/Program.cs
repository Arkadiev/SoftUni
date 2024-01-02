namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                long firstNumber = long.Parse(input[0]);
                long secondNumber = long.Parse(input[1]);

                if (firstNumber > secondNumber)
                {
                    long sum = 0;
                    
                    while (firstNumber != 0)
                    {
                        sum += firstNumber % 10;
                        firstNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(sum));
                }

                else
                {
                    long sum = 0;

                    while (secondNumber != 0)
                    {
                        sum += secondNumber % 10;
                        secondNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(sum));
                }
            }
        }
    }
}