/*
//Thi5 I5 MY 5trING!//
Translate 5 s
Includes string
Start //This
Lowercase
FindIndex i
Remove 0 10
End

*S0ftUni is the B3St Plac3**
Translate 2 o
Includes best
Start the
Lowercase
FindIndex p
Remove 2 7
End
 
*/

using System.Text;

namespace _01.StringManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                if (command == "Translate")
                {
                    string character = arguments[1];
                    string replacement = arguments[2];

                    text = text.Replace(character, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string substring = arguments[1];

                    if (text.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Start")
                {
                    string substring = arguments[1];

                    if (text.StartsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    string character = arguments[1];
                    int characterIndex = text.LastIndexOf(character);
                    Console.WriteLine(characterIndex);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int count = int.Parse(arguments[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }
            }
        }
    }
}