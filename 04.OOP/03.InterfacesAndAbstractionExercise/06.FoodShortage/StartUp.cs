namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4) // Citizen
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    citizens.Add(citizen);
                }
                else if (input.Length == 3) // Rebel
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    Rebel rebel = new Rebel(name, age, group);
                    rebels.Add(rebel);
                }
            }

            int foodPurchased = 0;

            string input2;
            while ((input2 = Console.ReadLine()) != "End")
            {
                if (citizens.Any(c => c.Name == input2))
                {
                    foodPurchased += 10;
                }
                else if (rebels.Any(r => r.Name == input2))
                {
                    foodPurchased += 5;
                }
            }

            Console.WriteLine(foodPurchased);
        }
    }
}