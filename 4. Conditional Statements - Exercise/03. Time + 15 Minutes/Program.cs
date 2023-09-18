using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double inHour = double.Parse(Console.ReadLine());
            double inMinutes = double.Parse(Console.ReadLine());
            double hours = inHour;
            double minutes = inMinutes + 15;

            if (hours <= 22 && minutes >= 60)
            {
                hours += 1;
                minutes = minutes - 60;
            }
            else if (hours >= 23 && minutes >= 60)
            {
                hours = hours - hours;
                minutes = minutes - 60;
            }
            Console.WriteLine(hours + ":" + minutes.ToString("00"));
        }
    }
}