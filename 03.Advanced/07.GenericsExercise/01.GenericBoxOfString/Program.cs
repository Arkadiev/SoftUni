namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Box<string> stringBox = new Box<string>();

            for (int i = 0; i < lines; i++)
            {
                stringBox.Add(Console.ReadLine());
            }

            Console.WriteLine(stringBox.ToString());
        }
    }
}