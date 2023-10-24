namespace _05.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            int shotTargets = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);

                if (targetIndex < 0 || targetIndex >= numbers.Count)
                {
                    continue;
                }

                int targetValue = numbers[targetIndex];

                if (numbers[targetIndex] == -1)
                {
                    continue;
                }

                numbers[targetIndex] = -1;
                shotTargets++;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == -1)
                    {
                        continue;
                    }
                    else if (targetValue < numbers[i])
                    {
                        numbers[i] -= targetValue;
                    }
                    else if (targetValue >= numbers[i])
                    {
                        numbers[i] += targetValue;
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", numbers)}");
        }
    }
}