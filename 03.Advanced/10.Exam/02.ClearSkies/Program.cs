namespace _02.ClearSkies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int enemyAircraft = 0;
            int armor = 300;

            int currentRow = 0;
            int currentCol = 0;

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row, col] == 'J')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (matrix[row, col] == 'E')
                    {
                        enemyAircraft++;
                    }
                }
            }

            matrix[currentRow, currentCol] = '-';

            while (true)
            {
                string input = Console.ReadLine();

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

                if (matrix[currentRow, currentCol] == 'R')
                {
                    armor = 300;
                    matrix[currentRow, currentCol] = '-';
                }

                if (matrix[currentRow, currentCol] == 'E')
                {
                    enemyAircraft--;
                    armor -= 100;
                    matrix[currentRow, currentCol] = '-';

                    if (enemyAircraft == 0)
                    {
                        matrix[currentRow, currentCol] = 'J';
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                    else if (armor == 0)
                    {
                        matrix[currentRow, currentCol] = 'J';
                        Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{currentRow}, {currentCol}]!");
                        break;
                    }
                }
            }

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