namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            Dictionary<double, int> times = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!times.ContainsKey(number))
                {
                    times[number] = 0;
                }

                times[number]++;
            }

            foreach (var number in times)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}