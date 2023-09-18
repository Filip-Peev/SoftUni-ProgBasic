using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examInMinutes = examHour * 60 + examMinute;
            int arrivalInMinutes = arrivalHour * 60 + arrivalMinute;

            int difference = Math.Abs(arrivalInMinutes - examInMinutes);
            int differenceHour = difference / 60;
            int differenceMinute = difference % 60;

            if (arrivalInMinutes > examInMinutes)
            {
                Console.WriteLine("Late");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{differenceHour}:{differenceMinute:D2} hours after the start");
                }
            }
            else if (arrivalInMinutes == examInMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (examInMinutes > arrivalInMinutes)
            {
                if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceHour}:{differenceMinute:D2} hours before the start");
                }
            }
        }
    }
}