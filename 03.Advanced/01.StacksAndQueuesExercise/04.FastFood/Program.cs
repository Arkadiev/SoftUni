namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);
            
            int sum = 0;

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                int currentNumber = queue.Peek();
                sum += currentNumber;

                if (sum <= quantity)
                {
                    queue.Dequeue();
                }
                else
                {
                    int[] arr = queue.ToArray();
                    Console.WriteLine($"Orders left: " + string.Join(" ", arr));
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}