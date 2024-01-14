namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            string[] numbers = Console.ReadLine().Split();

            Stack<int> stack = new Stack<int>();

            foreach (string number in numbers)
            {
                int currentNumber = int.Parse(number);
                stack.Push(currentNumber);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            bool isFound = false;
            int otherNum;

            if (stack.Count == 0)
            {
                otherNum = 0;
            }
            else
            {
                otherNum = int.MaxValue;
            }
            
            while (stack.Count > 0)
            {
                int currentNum = stack.Pop();
                
                if (currentNum == x)
                {
                    isFound = true;
                }
                else if (currentNum < otherNum)
                {
                    otherNum = currentNum;
                }
            }

            if (isFound == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(otherNum);
            }
        }
    }
}