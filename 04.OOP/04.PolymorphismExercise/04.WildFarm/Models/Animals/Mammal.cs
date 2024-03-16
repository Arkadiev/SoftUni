namespace WildFarm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        protected string LivingRegion;

        protected Mammal(string name, double weight, string livingRegion, string[] menu)
            : base(name, weight, menu) => LivingRegion = livingRegion;

        public override string ToString() => $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}