namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal difference = Math.Abs(firstNumber - secondNumber);

            if (firstNumber == secondNumber || difference < 0.000001m) { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }
        }
    }
}