namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            if (queue.Any())
            {
                Console.WriteLine(queue.Max());
            }
            
            while (queue.Any())
            {
                if (quantity >= queue.Peek())
                {
                    quantity -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}