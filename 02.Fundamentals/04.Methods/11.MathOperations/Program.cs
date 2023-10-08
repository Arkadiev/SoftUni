namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine(Result(firstNum, operator1, secondNum));

            static double Result(double firstNum, string operator1, double secondNum)
            {
                double result = 0;

                if (operator1 == "+") { result = firstNum + secondNum; }
                else if (operator1 == "-") { result = firstNum - secondNum; }
                else if (operator1 == "*") { result = firstNum * secondNum; }
                else if (operator1 == "/") { result = firstNum / secondNum; }

                return result;
            }
        }
    }
}