namespace _03.Calculations
{
    internal class Program
    {
        static void Calculation(string action, double num1, double num2)
        {
            if (action == "add") { Console.WriteLine(num1 + num2); }
            else if (action == "multiply") { Console.WriteLine(num1 * num2); }
            else if (action == "subtract") { Console.WriteLine(num1 - num2); }
            else if (action == "divide") { Console.WriteLine(num1 / num2); }
        }

        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Calculation(action, num1, num2);
        }
    }
}