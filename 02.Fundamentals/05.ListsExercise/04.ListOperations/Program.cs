using System.Reflection.Metadata.Ecma335;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input =Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                if (arguments[0] == "Add")
                {
                    list.Add(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Insert")
                {
                    int number = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);

                    if (IsNotValidIndex(index, list.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(index, number);
                    }
                    
                }
                else if (arguments[0] == "Remove")
                {
                    int index = int.Parse(arguments[1]);

                    if (IsNotValidIndex(index, list.Count))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(index);
                    }
                }
                else if (arguments[0] == "Shift")
                {
                    string direction = arguments[1];
                    int count = int.Parse(arguments[2]);
                    count %= list.Count;

                    if (direction == "left")
                    {
                        List<int> shiftedPart = list.GetRange(0, count);
                        list.RemoveRange(0, count);
                        list.InsertRange(list.Count, shiftedPart);
                    }
                    else if (direction == "right")
                    {
                        List<int> shiftedPart = list.GetRange(list.Count - count, count);
                        list.RemoveRange(list.Count - count, count);
                        list.InsertRange(0, shiftedPart);
                    }
                }

            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static bool IsNotValidIndex(int index, int count)
        {
            return index < 0 || index >= count;
        }
    }
}