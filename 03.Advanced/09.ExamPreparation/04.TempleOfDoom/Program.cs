namespace _04.TempleOfDoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> substances = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            List<int> challenges = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            while (tools.Count != 0 && substances.Count != 0 && challenges.Count != 0)
            {
                int currentTool = tools.Dequeue();
                int currentSubstance = substances.Pop();

                int currentPower = currentTool * currentSubstance;

                bool isResolved = false;

                for (int i = 0; i < challenges.Count; i++)
                {
                    if (currentPower == challenges[i])
                    {
                        challenges.RemoveAt(i);
                        isResolved = true;
                        break;
                    }
                }

                if (isResolved == false)
                {
                    currentTool++;
                    currentSubstance--;

                    tools.Enqueue(currentTool);

                    if (currentSubstance > 0)
                    {
                        substances.Push(currentSubstance);
                    }
                }
            }

            if (challenges.Count == 0)
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
            }
            else if (tools.Count == 0 || substances.Count == 0)
            {
                Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            }

            if (tools.Count != 0)
            {
                Console.Write("Tools: ");
                Console.WriteLine(string.Join(", ", tools));

            }
            if (substances.Count != 0)
            {
                Console.Write("Substances: ");
                Console.WriteLine(string.Join(", ", substances));
            }
            if (challenges.Count != 0)
            {
                Console.Write("Challenges: ");
                Console.WriteLine(string.Join(", ", challenges));
            }
        }
    }
}