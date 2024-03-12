using System.Text;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> list = new List<IIdentifiable>();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens.Length == 5) // Citizen
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthdate = tokens[4];

                    IIdentifiable citizen = new Citizen(name, age, id, birthdate);
                    list.Add(citizen);
                }
                else if (tokens.Length == 3 && tokens[0] == "Pet") // Pet
                {
                    string name = tokens[1];
                    string birthdate = tokens[2];

                    IIdentifiable pet = new Pet(name, birthdate);
                    list.Add(pet);
                }
            }

            string ending = Console.ReadLine();

            foreach (var entity in list)
            {
                if (entity.Birthdate.EndsWith(ending))
                {
                    Console.WriteLine(entity.Birthdate);
                }
            }
        }
    }
}