namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, studentGrade);
                }
                else
                {
                    students[studentName] = (students[studentName] + studentGrade) / 2;
                }
            }

            foreach (var studentPair in students)
            {
                if (studentPair.Value >= 4.50)
                {
                    Console.WriteLine($"{studentPair.Key} -> {studentPair.Value:f2}");
                }
            }
            
        }
    }
}