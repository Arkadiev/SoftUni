namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int factorial = 1;

                int currentNumber = int.Parse(number[i].ToString());

                for (int j = 1; j <= currentNumber; j++)
                {
                    factorial *= j;
                }

                sum += factorial;

            }

            if (sum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

        }
    }
}