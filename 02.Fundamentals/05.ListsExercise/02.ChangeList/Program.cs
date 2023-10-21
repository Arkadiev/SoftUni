namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();

                if (arguments[0] == "Delete")
                {
                    int element = int.Parse(arguments[1]);
                    list.RemoveAll(x => x == element);
                }
                else if (arguments[0] == "Insert")
                {
                    int element = int.Parse(arguments[1]);
                    int position = int.Parse(arguments[2]);
                    list.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}