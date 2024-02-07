namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Box<string> myBox = new Box<string>();

            for (int i = 0; i < lines; i++)
            {
                myBox.Add(Console.ReadLine());
            }

            string compareWith = Console.ReadLine();

            Console.WriteLine(myBox.Count(compareWith));
        }
    }
}