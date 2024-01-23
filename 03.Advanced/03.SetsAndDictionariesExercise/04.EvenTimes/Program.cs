namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<int, bool> numbers = new();

            for (int i = 0; i < lines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(currentNumber))
                {
                    numbers[currentNumber] = !numbers[currentNumber];
                }
                else
                {
                    numbers.Add(currentNumber, false);
                }
            }

            foreach (int number in numbers.Keys)
            {
                if (numbers[number])
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}