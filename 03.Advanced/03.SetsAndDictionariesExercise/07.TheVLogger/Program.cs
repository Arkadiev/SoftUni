using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlogger> theVlogger = new();

            string[] input;
            while ((input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries))[0] != "Statistics")
            {
                string username = input[0];
                string command = input[1];

                if (command.ToLower() == "joined")
                {
                    if (!theVlogger.ContainsKey(username))
                    {
                        Vlogger newVlogger = new(username, new SortedSet<string>(), new SortedSet<string>());
                        theVlogger.Add(username, newVlogger);
                    }
                    continue;
                }
                else if (command.ToLower() == "followed")
                {
                    string followedVlogger = input[2];

                    if (theVlogger.ContainsKey(username) && theVlogger.ContainsKey(followedVlogger) && username != followedVlogger)
                    {
                        theVlogger[username].Following.Add(followedVlogger);
                        theVlogger[followedVlogger].Followers.Add(username);
                    }
                    continue;
                }
            }

            var mostFamousVlogger = theVlogger.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count).FirstOrDefault();

            Console.WriteLine($"The V-Logger has a total of {theVlogger.Count} vloggers in its logs.");

            int i = 1;

            Console.WriteLine($"{i}. {mostFamousVlogger.Key} : {mostFamousVlogger.Value.Followers.Count} followers, {mostFamousVlogger.Value.Following.Count} following");

            foreach (var follower in mostFamousVlogger.Value.Followers)
            {
                Console.WriteLine($"*  {follower}");
            }

            theVlogger.Remove(mostFamousVlogger.Value.Name);

            i++;

            foreach (var vlogger in theVlogger.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                Console.WriteLine($"{i++}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");
            }
        }
    }

    public class Vlogger
    {
        public Vlogger(string name,SortedSet<string> followers, SortedSet<string> following)
        {
            Name = name;
            Followers = followers;
            Following = following;
        }

        public string Name { get; set; }

        public SortedSet<string> Followers { get; set; }

        public SortedSet<string> Following { get; set; }
    }
}