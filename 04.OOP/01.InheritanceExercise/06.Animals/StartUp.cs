namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string animalType;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] animalData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (animalType == "Dog")
                    {
                        Dog dog = new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(dog.GetType().Name);
                        Console.WriteLine(dog.ToString());
                        Console.WriteLine(dog.ProduceSound());
                    }
                    else if (animalType == "Cat")
                    {
                        Cat cat = new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(cat.GetType().Name);
                        Console.WriteLine(cat.ToString());
                        Console.WriteLine(cat.ProduceSound());
                    }
                    else if (animalType == "Frog")
                    {
                        Frog frog = new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(frog.GetType().Name);
                        Console.WriteLine(frog.ToString());
                        Console.WriteLine(frog.ProduceSound());
                    }
                    else if (animalType == "Kitten")
                    {
                        Kitten kitten = new Kitten(animalData[0], int.Parse(animalData[1]));
                        Console.WriteLine(kitten.GetType().Name);
                        Console.WriteLine(kitten.ToString());
                        Console.WriteLine(kitten.ProduceSound());
                    }
                    else if (animalType == "Tomcat")
                    {
                        Tomcat tomcat = new Tomcat(animalData[0], int.Parse(animalData[1]));
                        Console.WriteLine(tomcat.GetType().Name);
                        Console.WriteLine(tomcat.ToString());
                        Console.WriteLine(tomcat.ProduceSound());
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae);
                }
            }
        }
    }
}