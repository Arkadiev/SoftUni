namespace _06.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine().Split().ToList();
            
            string input;
            int movesCount = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                int[] index = input.Split().Select(int.Parse).ToArray();

                int firstIndex = index[0];
                int secondIndex = index[1];

                movesCount++;

                if (firstIndex == secondIndex || (firstIndex < 0 || firstIndex >= sequence.Count) || (secondIndex < 0 || secondIndex >= sequence.Count))
                {
                    string newSymbol = $"-{movesCount}a";
                    List<string> newElements = new List<string>() { newSymbol, newSymbol };

                    int middleIndex = sequence.Count / 2;
                    sequence.InsertRange(middleIndex, newElements);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (sequence[firstIndex] == sequence[secondIndex])
                    {
                        string element = sequence[firstIndex];
                        Console.WriteLine($"Congrats! You have found matching elements - {element}!");

                        if (firstIndex < secondIndex)
                        {
                            sequence.RemoveAt(firstIndex);
                            sequence.RemoveAt(secondIndex - 1);
                        }
                        else if (secondIndex < firstIndex)
                        {
                            sequence.RemoveAt(secondIndex);
                            sequence.RemoveAt(firstIndex - 1);
                        }
                    }
                    else if (sequence[firstIndex] != sequence[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }

                    if (sequence.Count == 0)
                    {
                        Console.WriteLine($"You have won in {movesCount} turns!");
                        break;
                    }
                }
            }

            if (sequence.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequence));
            }

        }
    }
}