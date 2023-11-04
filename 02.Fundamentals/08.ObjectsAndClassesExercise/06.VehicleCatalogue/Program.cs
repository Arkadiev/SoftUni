namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                double horsepower = int.Parse(arguments[3]);

                Vehicle newVehicle = new Vehicle(type, model, color, horsepower);

                vehicles.Add(newVehicle);

                if (type == "car")
                {
                    cars.Add(newVehicle);
                }
                else if (type == "truck")
                {
                    trucks.Add(newVehicle);
                }
            }

            string input2;
            while ((input2 = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.Find(x => x.Model == input2));
            }

                double carsHorsepower = 0;
            double trucksHorsepower = 0;

            foreach (Vehicle car in cars)
            {
                carsHorsepower += car.Horsepower;
            }

            foreach (Vehicle truck in trucks)
            {
                trucksHorsepower += truck.Horsepower;
            }

            double avgCarsHorsepower = carsHorsepower / cars.Count;
            double avgTrucksHorsepower = trucksHorsepower / trucks.Count;

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avgCarsHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double Horsepower { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {Model}{Environment.NewLine}" +
                                $"Color: {Color}{Environment.NewLine}" +
                                $"Horsepower: {Horsepower}";

            return vehicleStr;
        }
    }
}