namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                double grade = double.Parse(input[2]);

                Student student = new Student(input[0], input[1], grade);
                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}