namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalPassed = 0;

            Queue<string> cars = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    Console.WriteLine($"{totalPassed} cars passed the crossroads.");
                    break;
                }
                else if (input == "green")
                {
                    if (n > cars.Count)
                    {
                        n = cars.Count;
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }

                    totalPassed += n;
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
        }
    }
}