namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = CalcPower(a, b);
            Console.WriteLine(result);

        }

        static double CalcPower(double a, double b)
        {
            double power = Math.Pow(a, b);
            return power;
        }

    }
}