namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> list = new List<IIdentifiable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens.Length == 2) // Robot
                {
                    string model = tokens[0];
                    string id = tokens[1];

                    IIdentifiable robot = new Robot(model, id);

                    list.Add(robot);
                }
                else if (tokens.Length == 3) // Citizen
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];

                    IIdentifiable citizen = new Citizen(name, age, id);

                    list.Add(citizen);
                }
            }

            string ending = Console.ReadLine();

            foreach (IIdentifiable entity in list)
            {
                if (entity.Id.EndsWith(ending))
                {
                    Console.WriteLine(entity.Id);
                }
            }
        }
    }
}