namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i]);
                numbers.Push(currentNumber);
            }

            while (true)
            {
                string[] arguments = Console.ReadLine().Split();

                string command = arguments[0];

                if (command.Equals("Add", StringComparison.CurrentCultureIgnoreCase))
                {
                    int firstNumber = int.Parse(arguments[1]);
                    int secondNumber = int.Parse(arguments[2]);

                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }
                else if (command.Equals("Remove", StringComparison.CurrentCultureIgnoreCase))
                {
                    int number = int.Parse(arguments[1]);

                    if (numbers.Count >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            numbers.Pop();
                        }
                    }

                    continue;
                }
                else if (command.Equals("End", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine($"Sum: {numbers.Sum()}");

                    break;
                }
            }
        }
    }
}