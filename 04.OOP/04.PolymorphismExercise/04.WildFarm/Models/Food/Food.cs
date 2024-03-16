namespace WildFarm.Models.Food
{
    public abstract class Food
    {
        public int FoodQuantity;

        protected Food(int foodQuantity) => FoodQuantity = foodQuantity;
    }
}