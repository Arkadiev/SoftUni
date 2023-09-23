using System.Runtime.CompilerServices;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double sabersTotal = Math.Ceiling(students * 1.1) * saberPrice;
            double robesTotal = students * robePrice;

            int freeBelts = students / 6;

            double beltsTotal = (students - freeBelts) * beltPrice;

            double totalPrice = sabersTotal + robesTotal + beltsTotal;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }

        }
    }
}