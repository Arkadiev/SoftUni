namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 7) { Console.WriteLine("Invalid day!"); return; }
            Console.WriteLine(days[number - 1]);

            // ------------------------------------------------------

            //int num = int.Parse(Console.ReadLine());

            //switch (num)
            //{
            //    case 1: Console.WriteLine("Monday"); break;
            //    case 2: Console.WriteLine("Tuesday"); break;
            //    case 3: Console.WriteLine("Wednesday"); break;
            //    case 4: Console.WriteLine("Thursday"); break;
            //    case 5: Console.WriteLine("Friday"); break;
            //    case 6: Console.WriteLine("Saturday"); break;
            //    case 7: Console.WriteLine("Sunday"); break;
            //    default: Console.WriteLine("Invalid day!"); break;
            // }

            // ------------------------------------------------------

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //int input = int.Parse(Console.ReadLine());

            //if (input == numbers[0]) { Console.WriteLine("Monday"); }
            //else if (input == numbers[1]) { Console.WriteLine("Tuesday"); }
            //else if (input == numbers[2]) { Console.WriteLine("Wednesday"); }
            //else if (input == numbers[3]) { Console.WriteLine("Thursday"); }
            //else if (input == numbers[4]) { Console.WriteLine("Friday"); }
            //else if (input == numbers[5]) { Console.WriteLine("Saturday"); }
            //else if (input == numbers[6]) { Console.WriteLine("Sunday"); }
            //else { Console.WriteLine("Invalid day!"); }

        }
    }
}