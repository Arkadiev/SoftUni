﻿namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}