using System;

namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double wallLenght = double.Parse(Console.ReadLine());
            double roofHeight = double.Parse(Console.ReadLine());

            double sideWalls = 2 * (houseHeight * wallLenght - 2.25);
            double frontAndBackWalls = (houseHeight * houseHeight * 2) - 2.4;
            double totalHouseArea = sideWalls + frontAndBackWalls;

            double roofSides = 2 * houseHeight * wallLenght;
            double roofFrontAndBack = 2 * (houseHeight * roofHeight / 2);
            double totalRoofArea = roofSides + roofFrontAndBack;

            double greenPaint = totalHouseArea / 3.4;
            double redPaint = totalRoofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
