namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] dates = new string[2];

            for (int i = 0; i < 2; i++)
            {
                dates[i] = Console.ReadLine();
            }

            DateModifier dateModifier = new DateModifier(dates[0], dates[1]);

            Console.WriteLine(dateModifier.DifferenceInDays);
        }
    }
}