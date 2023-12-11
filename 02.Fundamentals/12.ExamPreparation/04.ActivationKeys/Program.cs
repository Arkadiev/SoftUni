namespace _04.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] arguments = input.Split(">>>");
                string command = arguments[0];
                
                if (command == "Contains")
                {
                    string substring = arguments[1];

                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string upperLower = arguments[1];
                    int startIndex = int.Parse(arguments[2]);
                    int endIndex = int.Parse(arguments[3]);

                    int substringLength = endIndex - startIndex;
                    string substring = rawKey.Substring(startIndex, substringLength);

                    if (upperLower == "Upper")
                    {
                        string replacement = rawKey.Substring(startIndex, substringLength).ToUpper();
                        rawKey = rawKey.Replace(substring, replacement);
                        Console.WriteLine(rawKey);
                    }
                    else if (upperLower == "Lower")
                    {
                        string replacement = rawKey.Substring(startIndex, substringLength).ToLower();
                        rawKey = rawKey.Replace(substring, replacement);
                        Console.WriteLine(rawKey);
                    }
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);
                    int substringLength = endIndex - startIndex;

                    rawKey = rawKey.Remove(startIndex, substringLength);
                    Console.WriteLine(rawKey);
                }
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}