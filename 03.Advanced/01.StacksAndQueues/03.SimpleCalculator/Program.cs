namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse().ToArray());

            int sum = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                char currentChar = char.Parse(stack.Pop());

                if (currentChar == '+')
                {
                    int currentNumber = int.Parse(stack.Pop());
                    sum += currentNumber;
                }
                else if (currentChar == '-')
                {
                    int currentNumber = int.Parse(stack.Pop());
                    sum -= currentNumber;
                }
            }

            Console.WriteLine(sum);
        }
    }
}