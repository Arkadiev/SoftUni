namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int start = brackets.Pop();
                    int end = i + 1;

                    string substring = expression.Substring(start, end - start);

                    Console.WriteLine(substring);
                }
            }
        }
    }
}