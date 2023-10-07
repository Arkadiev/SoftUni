namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void isPositive(int a)
        {
            if (a == 0) { Console.WriteLine($"The number {a} is zero."); }
            else if (a > 0) { Console.WriteLine($"The number {a} is positive."); }
            else if (a < 0) { Console.WriteLine($"The number {a} is negative."); }
        }

        static void Main(string[] args)
        {
            isPositive(int.Parse(Console.ReadLine()));

        }

    }
}