namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string color = input[0];
                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 1);
                    }
                    else
                    {
                        wardrobe[color][item]++;
                    }
                }
            }

            string[] searchInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if (searchInput[0] == color.Key && searchInput[1] == item.Key)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}