namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Box<double> myBox = new Box<double>();

            for (int i = 0; i < lines; i++)
            {
                myBox.Add(double.Parse(Console.ReadLine()));
            }

            double compareWith = double.Parse(Console.ReadLine());

            Console.WriteLine(myBox.Count(compareWith));
        }
    }
}