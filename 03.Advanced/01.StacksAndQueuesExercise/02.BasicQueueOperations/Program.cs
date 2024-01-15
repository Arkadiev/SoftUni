namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0], s = input[1], x = input[2];

            string[] numbers = Console.ReadLine().Split();

            Queue<int> queue = new Queue<int>();

            foreach (string number in numbers)
            {
                int currentNumber = int.Parse(number);
                queue.Enqueue(currentNumber);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}