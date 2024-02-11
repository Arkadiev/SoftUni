namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ListyIterator<string> listy = new(input.Skip(1).ToList());

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (command == "Print")
                {
                    try
                    {
                        listy.Print();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine("Invalid Operation!");
                    }
                    
                }
            }
        }
    }
}