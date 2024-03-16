namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double AirConditionerAdditionalConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionInLitersPerKm, tankCapacity, AirConditionerAdditionalConsumption) { }
    }
}