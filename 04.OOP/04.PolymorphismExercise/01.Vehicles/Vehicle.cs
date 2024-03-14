namespace Vehicles
{
    public abstract class Vehicle : IDriveable
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public void Drive(double distance)
        {
            var total = distance * FuelConsumption;

            if (total > FuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                FuelQuantity -= total;

                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            

        }

        public virtual void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}