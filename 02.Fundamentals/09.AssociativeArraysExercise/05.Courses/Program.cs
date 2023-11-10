namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");

                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!courses.ContainsKey(courseName))
                {
                    Course course = new Course(courseName);
                    courses.Add(course.Name, course);
                }

                courses[courseName].StudentNames.Add(studentName);
            }

            foreach (var coursesPair in courses)
            {
                Console.WriteLine(coursesPair.Value);
            }
        }
    }

    public class Course
    {
        public Course(string name)
        {
            Name = name;
            StudentNames = new List<string>();
        }

        public string Name;

        public List<string> StudentNames;

        public override string ToString()
        {
            string result = $"{Name}: {StudentNames.Count}\n";

            for (int i = 0; i < StudentNames.Count; i++)
            {
                result += $"-- {StudentNames[i]}\n";
            }

            return result.Trim();
        }
    }
}