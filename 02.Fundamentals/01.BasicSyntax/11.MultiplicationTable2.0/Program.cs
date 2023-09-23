namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int mult = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num} X {mult} = {num*mult}");
                mult++;
            } while (mult <= 10);

        }
    }
}