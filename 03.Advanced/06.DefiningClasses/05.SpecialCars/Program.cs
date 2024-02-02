using System.Diagnostics.Metrics;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            List <Tire[]> tireArrays = new List<Tire[]>();

            string tiresInput;
            while ((tiresInput = Console.ReadLine()) != "No more tires")
            {
                string[] arguments = tiresInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Tire tireOne = new Tire(int.Parse(arguments[0]), double.Parse(arguments[1]));
                Tire tireTwo = new Tire(int.Parse(arguments[2]), double.Parse(arguments[3]));
                Tire tireThree = new Tire(int.Parse(arguments[4]), double.Parse(arguments[5]));
                Tire tireFour = new Tire(int.Parse(arguments[6]), double.Parse(arguments[7]));

                Tire[] tiresArray = new Tire[] { tireOne, tireTwo, tireThree, tireFour };

                tireArrays.Add(tiresArray);
            }

            Dictionary<int, double> engines = new();

            string enginesInput;
            while ((enginesInput = Console.ReadLine()) != "Engines done")
            {
                string[] arguments = enginesInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int horsePower = int.Parse(arguments[0]);
                double cubicCapacity = double.Parse(arguments[1]);

                engines.Add(horsePower, cubicCapacity);
            }

            string specialInput;
            while ((specialInput = Console.ReadLine()) != "Show special")
            {
                string[] arguments = specialInput.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string make = arguments[0];
                string model = arguments[1];
                int year = int.Parse(arguments[2]);
                double fuelQuantity = double.Parse(arguments[3]);
                double fuelConsumption = double.Parse(arguments[4]);
                int engineIndex = int.Parse(arguments[5]);
                int tiresIndex = int.Parse(arguments[6]);

                Tire[] currentTiresArray = tireArrays[tiresIndex];

                int engineHorsePower = engines.ElementAt(engineIndex).Key;
                double engineCubicCapacity = engines.ElementAt(engineIndex).Value;

                Engine currentEngine = new(engineHorsePower, engineCubicCapacity);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, currentEngine, currentTiresArray);

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                double totalTirePressure = 0;

                foreach (Tire tire in car.Tires)
                {
                    totalTirePressure += tire.Pressure;
                }

                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && totalTirePressure > 9 && totalTirePressure < 10)
                {
                    car.Drive(0.2);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}