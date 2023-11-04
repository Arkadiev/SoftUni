namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamCommands = Console.ReadLine().Split("-");
                string teamName = teamCommands[1];
                string creatorName = teamCommands[0];

                Team team = new Team(teamName, creatorName);

                Team sameTeamFound = teams.Find(t => t.Name == team.Name);
                if (sameTeamFound != null)
                {
                    Console.WriteLine($"Team {sameTeamFound.Name} was already created!");
                    continue;
                }

                Team sameCreatorFound = teams.Find(t => t.Creator == team.Creator);
                if (sameCreatorFound != null)
                {
                    Console.WriteLine($"{sameCreatorFound.Creator} cannot create another team!");
                    continue;
                }

                teams.Add(team);
                Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = command.Split("->");
                string joinerName = arguments[0];
                string teamName = arguments[1];

                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(team => team.Creator == joinerName) || teams.Any(team => team.Members.Contains(joinerName)))
                {
                    Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                    continue;
                }

                teams.First(t => t.Name == teamName).Members.Add(joinerName);
            }

            List<Team> leftTeams = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();
            List<Team> disbandTeams = teams.Where(t => t.Members.Count <= 0).OrderBy(t => t.Name).ToList();

            foreach (Team team in leftTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public Team(string teamName, string creatorName)
        {
            Name = teamName;
            Creator = creatorName;
            Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}