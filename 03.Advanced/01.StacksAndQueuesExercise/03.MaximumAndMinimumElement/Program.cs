namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int number = input[1];
                    stack.Push(number);
                }
                else if (command == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (stack.Count > 0)
                    {
                        list = stack.OrderBy(x => x).ToList();
                        Console.WriteLine(list[list.Count - 1]);
                    }
                }
                else // 4
                {
                    if (stack.Count > 0)
                    {
                        list = stack.OrderBy(x => x).ToList();
                        Console.WriteLine(list[0]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}