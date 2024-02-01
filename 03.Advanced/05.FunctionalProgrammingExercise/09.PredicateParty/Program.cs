namespace _09.PredicateParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Func<string, bool> predicate = GetPredicate(arguments[1], arguments[2]);

                if (arguments[0] == "Remove")
                {
                    guestList = Remove(guestList, predicate);
                }
                else if (arguments[0] == "Double")
                {
                    guestList = Double(guestList, predicate);
                }
            }

            Console.WriteLine(guestList.Any() ? $"{string.Join(", ", guestList)} are going to the party!" : "Nobody is going to the party!");
        }

        static Func<string, bool> GetPredicate(string command, string substring)
        {
            if (command == "StartsWith")
            {
                return x => x.StartsWith(substring);
            }
            if (command == "EndsWith")
            {
                return x => x.EndsWith(substring);
            }
            if (command == "Length")
            {
                return x => x.Length == int.Parse(substring);
            }

            return null;
        }

        static List<string> Double(List<string> guestList, Func<string, bool> predicate)
        {
            List<string> result = new();

            foreach (string guest in guestList)
            {
                if (predicate(guest))
                {
                    result.Add(guest);
                }

                result.Add(guest);
            }

            return result;
        }

        static List<string> Remove(List<string> guestList, Func<string, bool> predicate)
        {
            return guestList.Where(guest => predicate(guest) == false).ToList();
        }
    }
}