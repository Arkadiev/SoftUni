namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] arr = word.Split(' ');

            int[] num = Array.ConvertAll(arr, int.Parse);

            if (num.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                leftSum = num.Take(i).Sum();

                rightSum = num.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

        }
    }
}