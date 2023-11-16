namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                if (isValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool isValidUsername(string username)
        {
            return username.All(ch => char.IsLetterOrDigit(ch) || ch == '-' || ch == '_');
        }
    }
}