namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double grams = 250;
        private const double calories = 250;
        private const decimal price = 5;

        public Cake(string name) : base(name, price, grams, calories)
        {
        }
    }
}