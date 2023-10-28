namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split('_').ToArray();
            }





        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public double Time {  get; set; }
    }


}