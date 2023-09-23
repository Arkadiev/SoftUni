using System;

namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            lenght = lenght * 100;
            width = width * 100;

            var lenghtTotal = Math.Floor(lenght / 120);
            var widthTotal = Math.Floor((width - 100) / 70);

            var totalSeats = (lenghtTotal * widthTotal) - 3;

            Console.WriteLine(totalSeats);

        }
    }
}
