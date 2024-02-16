namespace _05.MouseInTheKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            int totalCheese = 0;

            int currentRow = -1;
            int currentCol = -1;

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row, col] == 'M')
                    {
                        currentRow = row;
                        currentCol = col;

                        matrix[currentRow, currentCol] = '*';
                    }

                    if (matrix[row, col] == 'C')
                    {
                        totalCheese++;
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "danger")
            {
                matrix[currentRow, currentCol] = '*';

                if (input == "up" && currentRow == 0 || input == "down" && currentRow == rows - 1 ||
                    input == "left" && currentCol == 0 || input == "right" && currentCol == cols - 1)
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }

                if (input == "up" && matrix[currentRow - 1, currentCol] == '@' || input == "down" && matrix[currentRow + 1, currentCol] == '@' ||
                    input == "left" && matrix[currentRow, currentCol - 1] == '@' || input == "right" && matrix[currentRow, currentCol + 1] == '@')
                {
                    continue;
                }
                else
                {
                    if (input == "up")
                    {
                        currentRow--;
                    }
                    else if (input == "down")
                    {
                        currentRow++;
                    }
                    else if (input == "left")
                    {
                        currentCol--;
                    }
                    else if (input == "right")
                    {
                        currentCol++;
                    }
                }
               
                if (matrix[currentRow, currentCol] == 'C')
                {
                    totalCheese--;
                    matrix[currentRow, currentCol] = '*';

                    if (totalCheese == 0)
                    {
                        matrix[currentRow, currentCol] = 'M';
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        break;
                    }
                    continue;
                }

                if (matrix[currentRow, currentCol] == 'T')
                {
                    matrix[currentRow, currentCol] = 'M';
                    Console.WriteLine("Mouse is trapped!");
                    break;
                }
            }

            if (input == "danger")
            {
                Console.WriteLine("Mouse will come back later!");
            }

            matrix[currentRow, currentCol] = 'M';
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}