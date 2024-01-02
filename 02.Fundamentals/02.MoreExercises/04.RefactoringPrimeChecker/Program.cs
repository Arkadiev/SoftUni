namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int number = 2; number <= input; number++)
            {
                bool isPrime = true;
                for (int otherNumber = 2; otherNumber < number; otherNumber++)
                {
                    if (number % otherNumber == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                string prime = isPrime.ToString().ToLower();

                Console.WriteLine($"{number} -> {prime}");
            }
        }
    }
}