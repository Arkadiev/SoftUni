namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> delivery = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int rackCapacity = int.Parse(Console.ReadLine());

            int racksUsed = 1;
            int currentRackCapacity = rackCapacity;

            while (delivery.Any())
            {
                if (delivery.Peek() <= currentRackCapacity)
                {
                    currentRackCapacity -= delivery.Pop();
                }
                else
                {
                    racksUsed++;
                    currentRackCapacity = rackCapacity;
                }
            }

            Console.WriteLine(racksUsed);
        }
    }
}