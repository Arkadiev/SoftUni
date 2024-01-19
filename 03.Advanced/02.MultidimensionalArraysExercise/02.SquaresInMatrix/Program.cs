namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int squaresFound = 0;

            string[] previousRow = null;

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split();

                if (row > 0)
                {
                    for (int col = 0; col < cols - 1; col++)
                    {
                        if (currentRow[col] == currentRow[col + 1] &&
                            currentRow[col] == previousRow[col] &&
                            currentRow[col] == previousRow[col + 1])
                        {
                            squaresFound++;
                        }
                    }
                }

                previousRow = currentRow;
            }

            Console.WriteLine(squaresFound);
        }
    }
}