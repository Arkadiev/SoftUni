using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comm = 0;

            switch (city)
            {
                case "Sofia":
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    else if (sales >= 0 && sales <= 500)
                    {
                        comm = 5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = 7;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        comm = 8;
                    }
                    else if (sales > 10000)
                    {
                        comm = 12;
                    }
                    break;

                case "Varna":
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    else if (sales >= 0 && sales <= 500)
                    {
                        comm = 4.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = 7.5;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        comm = 10;
                    }
                    else if (sales > 10000)
                    {
                        comm = 13;
                    }
                    break;

                case "Plovdiv":
                    if (sales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    else if (sales >= 0 && sales <= 500)
                    {
                        comm = 5.5;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = 8;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        comm = 12;
                    }
                    else if (sales > 10000)
                    {
                        comm = 14.5;
                    }
                    break;

                default: Console.WriteLine("error"); break;
            }

            if (comm > 0)
            {
                double result = sales * comm / 100;

                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
