namespace MidExam01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfCities = int.Parse(Console.ReadLine());
            double grandTotal = 0;

            for (int city = 1; city <= numberOfCities; city++)
            {
                string cityName = Console.ReadLine();
                double ownerIncome = double.Parse(Console.ReadLine());
                double ownerExpenses = double.Parse(Console.ReadLine());

                
                if (city % 3 == 0)
                {
                    ownerExpenses = ownerExpenses / 2;

                }
                else if (city % 5 == 0)
                {
                    ownerIncome = ownerIncome * 0.9;
                }

                double totalProfit = ownerIncome - ownerExpenses;

                grandTotal += totalProfit;
                Console.WriteLine($"In {cityName} Burger Bus earned {totalProfit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {grandTotal:f2} leva.");
        }
    }
}
/*
5
Lille
2226.00
1200.60
Rennes
6320.60
5460.20
Reims
600.20
452.32
Bordeaux
6925.30
2650.40
Montpellier
680.50
290.20

 */