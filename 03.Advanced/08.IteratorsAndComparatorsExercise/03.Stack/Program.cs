namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();

            string input;
            string[] delims = {", ", " " };
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        stack.Push(command[i]);
                    }
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException iop)
                    {
                        Console.WriteLine("No elements");
                    }
                }
            }

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}