namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int count = 0;

            while (count < 4)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (input != password && count == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else if (input != password)
                {
                    count++;
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
            }

        }
    }
}