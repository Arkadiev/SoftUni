namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Queue<int> queue = new Queue<int>();

            foreach (string number in input)
            {
                int currentNumber = int.Parse(number);
                queue.Enqueue(currentNumber);
            }

            Queue<int> newQueue = new Queue<int>();

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();

                if (number % 2 == 0)
                {
                    newQueue.Enqueue(number);
                }
            }

            while (newQueue.Count > 1)
            {
                Console.Write(newQueue.Dequeue() + ", ");
            }

            Console.Write(newQueue.Dequeue());
        }
    }
}