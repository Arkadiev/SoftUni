namespace _06.HeroesOfCodeAndLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

            for (int i = 0; i < heroesCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string heroName = input[0];
                int heroHP = int.Parse(input[1]);
                int heroMP = int.Parse(input[2]);

                if (heroHP > 100) { heroHP = 100; }
                if (heroMP > 200) { heroMP = 200; }

                heroesHP.Add(heroName, heroHP);
                heroesMP.Add(heroName, heroMP);
            }

            string inputWhile;
            while ((inputWhile = Console.ReadLine()) != "End")
            {
                string[] arguments = inputWhile.Split(" - ");

                string command = arguments[0];
                string heroName = arguments[1];

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(arguments[2]);
                    string spellName = arguments[3];

                    if (heroesMP[heroName] >= mpNeeded)
                    {
                        heroesMP[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMP[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(arguments[2]);
                    string attacker = arguments[3];

                    heroesHP[heroName] -= damage;

                    if (heroesHP[heroName] <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroesHP.Remove(heroName);
                        heroesMP.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHP[heroName]} HP left!");
                    }
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(arguments[2]);

                    if (heroesMP[heroName] + amount > 200)
                    {
                        amount = 200 - heroesMP[heroName];
                    }

                    heroesMP[heroName] += amount;

                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(arguments[2]);

                    if (heroesHP[heroName] + amount > 100)
                    {
                        amount = 100 - heroesHP[heroName];
                    }

                    heroesHP[heroName] += amount;

                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }

            foreach (var hero in heroesHP)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroesMP[hero.Key]}");
            }
        }
    }
}