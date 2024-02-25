namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override void Drive(double kilometers)
        {
            Fuel -= kilometers * 8;
        }
    }
}