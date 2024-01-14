﻿namespace _02.BasicQueueOperations
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

            Queue<int> queue = new Queue<int>();

            foreach (string number in numbers)
            {
                int currentNumber = int.Parse(number);
                queue.Enqueue(currentNumber);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            bool isFound = false;
            int otherNum;

            if (queue.Count == 0)
            {
                otherNum = 0;
            }
            else
            {
                otherNum = int.MaxValue;
            }

            while (queue.Count > 0)
            {
                int currentNum = queue.Dequeue();

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