﻿using System.Reflection.Metadata.Ecma335;

namespace _03.DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(", ").ToArray();

                if (arguments[0] == "Add")
                {
                    if (cards.Contains(arguments[1]))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cards.Add(arguments[1]);
                        Console.WriteLine("Card successfully added");
                    }
                }

                if (arguments[0] == "Remove")
                {
                    if (cards.Contains(arguments[1]))
                    {
                        cards.Remove(arguments[1]);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }

                if (arguments[0] == "Remove At")
                {
                    int index = int.Parse(arguments[1]);
                    if (index < 0 || index > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }

                if (arguments[0] == "Insert")
                {
                    int index = int.Parse(arguments[1]);
                    if (index < 0 || index > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (cards.Contains(arguments[2]))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        cards.Insert(index, arguments[2]);
                        Console.WriteLine("Card successfully added");
                    }

                }

            }

            Console.WriteLine(string.Join(", ", cards));


        }
    }
}