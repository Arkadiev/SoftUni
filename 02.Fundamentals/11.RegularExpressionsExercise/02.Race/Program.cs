using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participantsNames = Console.ReadLine().Split(", ").ToList();
            List<Participant> participants = new List<Participant>();

            foreach (string name in participantsNames)
            {
                Participant participant = new Participant(name);
                participants.Add(participant);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder nameBuilder = new StringBuilder();
                string lettersPattern = @"[A-Za-z]";
                foreach (Match letter in Regex.Matches(input, lettersPattern))
                {
                    nameBuilder.Append(letter.Value);
                }

                string participantName = nameBuilder.ToString();

                uint distance = 0;
                string digitsPattern = @"\d";
                foreach (Match digit in Regex.Matches(input, digitsPattern))
                {
                    distance += uint.Parse(digit.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(p => p.Name == participantName);
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }
            }

            List<Participant> firstThreeParticipants = participants.OrderByDescending(p => p.Distance).Take(3).ToList();

            Console.WriteLine($"1st place: {firstThreeParticipants[0].Name}");
            Console.WriteLine($"2nd place: {firstThreeParticipants[1].Name}");
            Console.WriteLine($"3rd place: {firstThreeParticipants[2].Name}");
        }
    }

    public class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public uint Distance { get; set; }
    }
}