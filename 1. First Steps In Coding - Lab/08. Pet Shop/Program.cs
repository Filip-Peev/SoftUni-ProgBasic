using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // кучета е на цена 2.50 лв, а опаковка храна за котки струва 4 лв.
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());

            Console.WriteLine($"{dogFood * 2.5 + catFood * 4} lv.");
        }
    }
}