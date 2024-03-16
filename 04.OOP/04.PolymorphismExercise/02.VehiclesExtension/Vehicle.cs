namespace VehiclesExtension
{
    public abstract class Vehicle : IDriveable
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                else if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get => tankCapacity;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Tank capacity must be positive number");
                }

                tankCapacity = value;

                if (value < TankCapacity)
                {
                    fuelQuantity = value;
                }
                else

                {
                    fuelQuantity = 0;
                }
            }
        }

        public virtual void Drive(double distance)
        {
            var total = distance * FuelConsumption;

            if (total > FuelQuantity)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }
            else
            {
                FuelQuantity -= total;

                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            double totalAfterRefueling = liters + FuelQuantity;

            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            if (totalAfterRefueling > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            FuelQuantity += liters;
        }
    }
}