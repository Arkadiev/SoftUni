using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            string state = "";
            string keyword = "";

            if (arrivalTime > examTime)
            {
                state = "Late";
                keyword = "after";
            }
            else
            {
                keyword = "before";
                if (arrivalTime >= examTime - 30)
                {
                    state = "On time";
                }
                else
                {
                    state = "Early";
                }
            }

            int diff = Math.Abs(examTime - arrivalTime);
            string formattedDiff = "";

            if (diff >= 60)
            {
                int diffHours = diff / 60;
                int diffMinutes = diff % 60;
                if (diffMinutes < 10) formattedDiff = $"{diffHours}:0{diffMinutes} hours";
                else formattedDiff = $"{diffHours}:{diffMinutes} hours";
            }
            else
            {
                formattedDiff = $"{diff} minutes";
            }

            Console.WriteLine(state);
            Console.WriteLine($"{formattedDiff} {keyword} the start");
        }
    }
}
