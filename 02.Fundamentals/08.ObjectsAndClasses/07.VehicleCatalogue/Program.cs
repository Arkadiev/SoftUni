namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split("/");

                string type = arguments[0];
                string brand = arguments[1];
                string model = arguments[2];
                int specs = int.Parse(arguments[3]);

                if (type == "Car")
                {
                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = specs;

                    cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = specs;

                    truck.Brand = brand;

                    trucks.Add(truck);
                }

            }

            List<Car> carsSorted = cars.OrderBy(car => car.Brand).ToList();
            List<Truck> trucksSorted = trucks.OrderBy(trucks => trucks.Brand).ToList();

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in carsSorted)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in trucksSorted)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }

        public class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }
        }

        public class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }
        }
    }
}