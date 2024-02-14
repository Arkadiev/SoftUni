namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> text = new();

            int n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine()!;
                if (text.Count == 0)
                {
                    if (command[0] == '1') text.Push(command[2..]);
                    continue;
                }

                string current = text.Peek();

                if (command[0] == '1')
                {
                    text.Push(current + command[2..]);
                }
                else if (command[0] == '2')
                {
                    text.Push(current[..^int.Parse(command[2..])]);
                }
                else if (command[0] == '3')
                {
                    Console.WriteLine(current[int.Parse(command[2..]) - 1]);
                }
                else if (command[0] == '4')
                {
                    text.Pop();
                }
            }
        }
    }
}