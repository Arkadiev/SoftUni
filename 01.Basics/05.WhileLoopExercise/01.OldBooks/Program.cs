using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookToLookFor = Console.ReadLine();
            string bookInput = Console.ReadLine();
            int checkedBooksCount = 0;
            bool isFound = false;

            while (bookInput != "No More Books")
            {
                if (bookInput == bookToLookFor)
                {
                    isFound = true;
                    break;
                }

                checkedBooksCount++;
                bookInput = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {checkedBooksCount} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooksCount} books.");
            }
        }
    }
}
