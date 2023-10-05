namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestIndex = 1;
            int bestIndexArray = 0;
            int bestSum = 0;
            int j = 1;
            int maxInARow = int.MinValue;
            int[] dnaSequemce = new int[n];
            string value = string.Empty;
            bool onlyZeroAndOne = true;
            while ((value = Console.ReadLine()) != "Clone them!")
            {
                int[] arr = new int[n];
                arr = value.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 1 && arr[i] != 0)
                    {
                        onlyZeroAndOne = false;
                    }
                }
                if (arr.Length == n && onlyZeroAndOne)
                {
                    int inARow = 0;
                    maxInARow = 0;
                    int index = 0;
                    int sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (arr[i] == 1)
                        {
                            inARow++;
                            if (inARow >= maxInARow)
                            {
                                maxInARow = inARow;
                                if (inARow == 1)
                                {
                                    index = i;
                                }
                            }
                            sum += arr[i];
                        }
                        else
                        {
                            inARow = 0;
                        }
                        if (j == 1)
                        {
                            dnaSequemce = arr;
                            if (inARow >= maxInARow)
                            {
                                maxInARow = inARow;
                                if (inARow == 1)
                                {
                                    bestIndexArray = i;
                                }
                            }
                        }
                    }
                    if (index < bestIndexArray)
                    {
                        dnaSequemce = arr;
                        bestSum = sum;
                        bestIndex = j;
                        bestIndexArray = index;
                    }
                    else if (index == bestIndexArray)
                    {
                        if (bestSum < sum)
                        {
                            dnaSequemce = arr;
                            bestSum = sum;
                            bestIndex = j;
                        }
                    }
                    j++;
                }
                else
                {
                    if (arr.Length == 0)
                    {
                        break;
                    }
                    continue;
                }
            }
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", dnaSequemce));
        }
    }
}