namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = default;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] inputTokens = line.Split().ToArray();
                string command = inputTokens[0];
                int index = int.Parse(inputTokens[1]);
                int value = int.Parse(inputTokens[2]);

                if (command == "Shoot")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else // Strike
                {
                    if (IsValidIndex(index, targets) && IsValidIndex(index + value, targets) && IsValidIndex(index - value, targets))
                    {
                        for (int i = 1; i <= value; i++)
                        {
                            targets.RemoveAt(index + i);
                        }

                        targets.RemoveAt(index);

                        for (int i = 1; i <= value; i++)
                        {
                            targets.RemoveAt(index - i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

            }

            Console.WriteLine(string.Join("|", targets));

        }

        static bool IsValidIndex(int index, List<int> targets)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}