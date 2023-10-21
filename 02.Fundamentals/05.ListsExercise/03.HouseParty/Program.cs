namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < guestsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string name = arguments[0];

                if (arguments[2] == "going!")
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (arguments[2] == "not")
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }

        }
    }
}