namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0], s = input[1], x = input[2];

            string[] numbers = Console.ReadLine().Split();

            Stack<int> stack = new Stack<int>();

            foreach (string number in numbers)
            {
                int currentNumber = int.Parse(number);
                stack.Push(currentNumber);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}