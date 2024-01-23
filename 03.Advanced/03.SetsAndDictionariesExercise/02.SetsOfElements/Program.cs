namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lines = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();

            HashSet<int> setThree = new HashSet<int>();

            for (int i = 0; i < lines[0]; i++)
            {
                setOne.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lines[1]; i++)
            {
                setTwo.Add(int.Parse(Console.ReadLine()));
            }

            setOne.IntersectWith(setTwo);

            Console.Write($"{string.Join(" ", setOne)}");
        }
    }
}