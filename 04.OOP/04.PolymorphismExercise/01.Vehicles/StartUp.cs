namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            string[] truckInput = Console.ReadLine().Split();

            Car car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
            Truck truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Drive")
                {
                    if (input[1] == "Car")
                    {
                        car.Drive(double.Parse(input[2]));
                    }
                    else if (input[1] == "Truck")
                    {
                        truck.Drive(double.Parse(input[2]));
                    }
                }
                else if (input[0] == "Refuel")
                {
                    if (input[1] == "Car")
                    {
                        car.Refuel(double.Parse(input[2]));
                    }
                    else if (input[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(input[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}