using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());

                double savedMoney = 0;

                while (savedMoney < budget)
                {
                    double currentSavedMoney = double.Parse(Console.ReadLine());
                    savedMoney += currentSavedMoney;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
