namespace _01.ChickenSnack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> money = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> foods = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int difference = 0;
            int foodEaten = 0;

            while (money.Count > 0 && foods.Count > 0)
            {
                int currentMoney = money.Pop() + difference;
                difference = 0;
                int currentFood = foods.Dequeue();

                if (currentMoney == currentFood)
                {
                    foodEaten++;
                }
                else if (currentMoney > currentFood)
                {
                    foodEaten++;
                    difference += currentMoney - currentFood;
                }
            }

            if (foodEaten >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodEaten} foods.");
            }
            else if (foodEaten == 1)
            {
                Console.WriteLine($"Henry ate: 1 food.");

            }
            else if (foodEaten < 4 && foodEaten > 1)
            {
                Console.WriteLine($"Henry ate: {foodEaten} foods.");
            }
            else if (foodEaten == 0)
            {
                Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}