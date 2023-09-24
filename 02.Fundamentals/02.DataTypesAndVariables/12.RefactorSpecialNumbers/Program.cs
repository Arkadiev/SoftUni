namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int ch = 1; ch <= num; ch++)
            {
                int lastChar = ch;

                while (ch > 0)
                {
                    sum += ch % 10;
                    ch /= 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{lastChar} -> {isSpecial}");
                
                sum = 0;
                ch = lastChar;
            }

        }
    }
}