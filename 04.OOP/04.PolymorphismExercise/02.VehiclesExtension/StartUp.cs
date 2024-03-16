namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carData = Console.ReadLine().Split();
            var truckData = Console.ReadLine().Split();
            var busData = Console.ReadLine().Split();

            Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));
            Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));
            Bus bus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                try
                {
                    var data = Console.ReadLine().Split();

                    if (data[0] == "Drive")
                    {
                        if (data[1] == "Car")
                        {
                            car.Drive(double.Parse(data[2]));
                        }
                        else if (data[1] == "Truck")
                        {
                            truck.Drive(double.Parse(data[2]));
                        }
                        else if (data[1] == "Bus")
                        {
                            bus.DriveWithPeople(double.Parse(data[2]));
                        }
                    }
                    else if (data[0] == "Refuel")
                    {
                        if (data[1] == "Car")
                        {
                            car.Refuel(double.Parse(data[2]));
                        }
                        else if (data[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(data[2]));
                        }
                        else if (data[1] == "Bus")
                        {
                            bus.Refuel(double.Parse(data[2]));
                        }
                    }
                    else if (data[1] == "DriveEmpty")
                    {
                        bus.Drive(double.Parse(data[2]));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}