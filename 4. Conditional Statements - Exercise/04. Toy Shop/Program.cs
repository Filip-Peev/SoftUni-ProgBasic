using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());
            double dolls = double.Parse(Console.ReadLine());
            double bears = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());

            double sumMoney = (puzzles * 2.60) + (dolls * 3.00) + (bears * 4.10) + (minions * 8.20) + (trucks * 2.00);
            double toysCount = puzzles + dolls + bears + minions + trucks;

            if (toysCount >= 50)
            {
                sumMoney = sumMoney - (sumMoney * 0.25);
            }

            double rent = sumMoney * 0.10;
            double profit = sumMoney - rent;
            
            if (profit >= vacation)
            {
                Console.WriteLine($"Yes! {profit - vacation:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacation - profit:F2} lv needed.");
            }
        }
    }
}
