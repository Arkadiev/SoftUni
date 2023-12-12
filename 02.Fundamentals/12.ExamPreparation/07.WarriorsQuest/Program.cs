/*
fr1c710n
GladiatorStance
Dispel 2 I
Dispel 4 T
Target Change RICTION riction
For Azeroth

DYN4MICNIC
Target Remove NIC
Dispel 3 A
DefensiveStance
Target Change d D
target change D d
For Azeroth

TR1GG3R
Dispel 2 I
Dispel 5 E
For Azeroth

*/

using System.Text;

namespace _07.WarriorsQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "GladiatorStance")
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                }
                else if (command == "DefensiveStance")
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                }
                else if (command == "Dispel")
                {
                    int index = int.Parse(arguments[1]);
                    string replacement = arguments[2];

                    if (index >= 0 && index < skill.Length)
                    {
                        skill = skill.Remove(index, replacement.Length);
                        skill = skill.Insert(index, replacement);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak!");
                    }
                }
                else if (command == "Target")
                {
                    string secondWord = arguments[1];

                    if (secondWord == "Change")
                    {
                        string firstSubstring = arguments[2];
                        string secondSubstring = arguments[3];

                        if (skill.Contains(firstSubstring))
                        {
                            skill = skill.Replace(firstSubstring, secondSubstring);
                            Console.WriteLine(skill);
                        }
                        else
                        {
                            Console.WriteLine(skill);
                        }
                    }
                    else if (secondWord == "Remove")
                    {
                        string substring = arguments[2];

                        if (skill.Contains(substring))
                        {
                            skill = skill.Remove(skill.IndexOf(substring), substring.Length);
                            Console.WriteLine(skill);
                        }
                        else
                        {
                            continue;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }

            Dictionary<int, string > dictionary = new Dictionary<int, string>();

            dictionary.Contains
        }
    }
}