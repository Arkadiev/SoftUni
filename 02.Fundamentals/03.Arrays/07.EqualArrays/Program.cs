using System.Diagnostics.CodeAnalysis;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            bool areIdentical = true;

            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    areIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index"); break;
                }
                else
                {
                    sum += numbers1[i];
                }
            }

            if (areIdentical == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }

    }
}