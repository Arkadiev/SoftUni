namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggestKegModel = "";
            double biggestKegVolume = 0;

            for (int i = 0; i < kegsCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                double kegHeight = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}