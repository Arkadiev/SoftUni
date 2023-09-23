using System;
using System.Dynamic;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSoldTickets = 0, studentTickets = 0, standardTickets = 0, kidTickets = 0;

            string movieName = Console.ReadLine();
            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());

                int soldTickets = 0;

                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End") { break; }
                    else if (ticketType == "student") { studentTickets++; }
                    else if (ticketType == "standard") { standardTickets++; }
                    else if (ticketType == "kid") { kidTickets++; }

                    soldTickets++;
                }

                double fillPercentage = 100.0 * soldTickets / freeSeats;
                Console.WriteLine($"{movieName} - {fillPercentage:f2}% full.");

                totalSoldTickets += soldTickets;
                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalSoldTickets}");
            Console.WriteLine($"{100.0 * studentTickets / totalSoldTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standardTickets / totalSoldTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidTickets / totalSoldTickets:f2}% kids tickets.");
        }
    }
}
