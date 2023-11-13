namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banwords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();
            
            foreach (var banword in banwords)
            {
                if (text.Contains(banword))
                {
                    text = text.Replace(banword, new string('*', banword.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}