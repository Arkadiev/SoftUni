namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> party = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroClass = Console.ReadLine();

                if (heroClass == "Druid")
                {
                    Druid druid = new Druid(heroName);
                    party.Add(druid);
                }
                else if (heroClass == "Paladin")
                {
                    Paladin paladin = new Paladin(heroName);
                    party.Add(paladin);
                }
                else if (heroClass == "Rogue")
                {
                    Rogue rogue = new Rogue(heroName);
                    party.Add(rogue);
                }
                else if (heroClass == "Warrior")
                {
                    Warrior warrior = new Warrior(heroName);
                    party.Add(warrior);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int partyPower = 0;

            foreach (BaseHero hero in party)
            {
                Console.WriteLine(hero.CastAbility());

                if (hero.GetType().Name == "Druid" ||  hero.GetType().Name == "Rogue")
                {
                    partyPower += 80;
                }
                else if (hero.GetType().Name == "Paladin" || hero.GetType().Name == "Warrior")
                {
                    partyPower += 100;
                }

                if (partyPower >= bossPower)
                {
                    Console.WriteLine("Victory!");
                    return;
                }
            }

            Console.WriteLine("Defeat...");
        }
    }
}