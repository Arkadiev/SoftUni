﻿namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                var pizzaData = Console.ReadLine().Split();
                Pizza pizza = new Pizza(pizzaData[1]);

                var doughData = Console.ReadLine().Split();
                Dough dough = new Dough(doughData[1], doughData[2], double.Parse(doughData[3]));

                pizza.Dough = dough;

                string command;
                while((command = Console.ReadLine()) != "END")
                {
                    var tokens = command.Split();

                    Topping topping = new Topping(tokens[1], double.Parse(tokens[2]));

                    pizza?.AddToppings(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
        }
    }
}