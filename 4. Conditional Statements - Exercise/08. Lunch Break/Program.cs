using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string showName = Console.ReadLine();
            double showLenght = double.Parse(Console.ReadLine());
            double rest = double.Parse(Console.ReadLine());

            // You have to force it to use Double by placing "d" at the end or it uses Int for some reason...
            double lunchTime = rest * (1 / 8d);
            double restTime = rest * (1d / 4);
            
            double remainingTime = rest - lunchTime - restTime;
            
            if (showLenght <= remainingTime)
            {
                Console.WriteLine($"You have enough time to watch {showName} and left with {Math.Ceiling(remainingTime - showLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {showName}, you need {Math.Ceiling(showLenght - remainingTime)} more minutes.");
            }
        }
    }
}
