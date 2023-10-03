namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
                sum += num;

            }

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}