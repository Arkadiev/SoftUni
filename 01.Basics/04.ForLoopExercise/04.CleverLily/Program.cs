using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toysCount = 0, savedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) { savedMoney += i * 5 - 1; }
                else { toysCount++; }
            }

            savedMoney += toysCount * toyPrice;

            if (savedMoney >= washingMachinePrice) { Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}"); }
            else { Console.WriteLine($"No! {washingMachinePrice - savedMoney:f2}"); }
        }
    }
}
