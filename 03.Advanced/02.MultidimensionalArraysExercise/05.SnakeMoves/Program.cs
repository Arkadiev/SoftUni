namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string snake = Console.ReadLine();

            string[,] matrix = new string[sizes[0], sizes[1]];

            int snakeCounter = 0;

            for (int row = 0; row < sizes[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < sizes[1]; col++)
                    {
                        matrix[row, col] = snake[snakeCounter].ToString();
                        snakeCounter = GetSnakeValue(snake, snakeCounter);
                    }
                }
                else
                {
                    for (int col = sizes[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[snakeCounter].ToString();
                        snakeCounter = GetSnakeValue(snake, snakeCounter);
                    }
                }
            }

            for (int row = 0; row < sizes[0]; row++)
            {
                for (int col = 0; col < sizes[1]; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }

                Console.WriteLine();
            }
        }

        static int GetSnakeValue(string snake, int snakeCounter)
        {
            snakeCounter++;

            if (snakeCounter >= snake.Length)
            {
                snakeCounter = 0;
            }

            return snakeCounter;
        }
    }
}