namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double fuelConsumptionModifier = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + fuelConsumptionModifier)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}