namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int size = int.Parse(Console.ReadLine());

            int sumDiagonalOne = 0;
            int sumDiagonalTwo = 0;

            int[,] matrix = new int[size, size];

            // Longer Solution:
            
            //for (int row = 0; row < size; row++)
            //{
            //    int[] newRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //    for (int col = 0; col < size; col++)
            //    {
            //        matrix[row, col] = newRow[col];

            //        if (row == col)
            //        {
            //            sumDiagonalOne += matrix[row, col];
            //        }
            //    }
            //}

            //for (int row = 0; row < size; row++)
            //{
            //    sumDiagonalTwo += matrix[row, size - 1 - row];
            //}

            // Shorter Solution:

            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                sumDiagonalOne += row[i];
                sumDiagonalTwo += row[size - 1 - i];
            }

            // Output:
            Console.WriteLine(Math.Abs(sumDiagonalOne - sumDiagonalTwo));
        }
    }
}