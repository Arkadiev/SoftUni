namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");

                string companyName = arguments[0];
                string employeeID = arguments[1];

                if (!companies.ContainsKey(companyName))
                {
                    Company company = new Company(companyName);
                    companies.Add(companyName, company);
                }

                if (!companies[companyName].Employees.Contains(employeeID))
                {
                    companies[companyName].Employees.Add(employeeID);
                }
            }

            foreach (var companyPair in companies)
            {
                Console.WriteLine(companyPair.Value);
            }
        }
    }

    public class Company
    {
        public Company(string name)
        {
            Name = name;
            Employees = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Employees { get; set;}

        public override string ToString()
        {
            string result = $"{Name}\n";

            for (int i = 0; i < Employees.Count; i++)
            {
                result += $"-- {Employees[i]}\n";
            }

            return result.Trim();
        }
    }
}