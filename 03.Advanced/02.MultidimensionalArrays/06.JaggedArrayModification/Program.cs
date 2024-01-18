using System.Numerics;

namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] arguments = command.Split();

                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);

                if (row < 0 || row >= jaggedArray.Length || col < 0 || jaggedArray[row].Length <= col)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (arguments[0] == "add")
                {
                    jaggedArray[row][col] += value;
                }
                else // Subtract
                {
                    jaggedArray[row][col] -= value;
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}