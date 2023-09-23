namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reverse = new string(text.Reverse().ToArray());
            Console.Write(reverse);


        }
    }
}