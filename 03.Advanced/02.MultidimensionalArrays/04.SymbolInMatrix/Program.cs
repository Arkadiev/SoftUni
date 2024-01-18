namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int rows = input;
            int cols = input;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] rowArray = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        return;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}