namespace _04.Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake lake = new Lake(list);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}