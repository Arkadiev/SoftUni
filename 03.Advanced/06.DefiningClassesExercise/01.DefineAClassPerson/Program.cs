namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person Peter = new Person
            {
                Name = "Peter",
                Age = 20
            };

            Person George = new Person("George", 18);

            Person Jose = new("Jose", 48);
        }
    }
}