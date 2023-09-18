using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double price = 0.0;
            bool areEven = (fisherman % 2 == 0);

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                    price = 4200;
                    break;
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
                default:
                    break;
            }
            if (fisherman <= 6)
            {
                price -= price * 0.1;
            }
            else if (fisherman > 7 && fisherman <= 11)
            {
                price -= price * 0.15;
            }
            else if (fisherman > 12)
            {
                price -= price * 0.25;
            }
            if (areEven && season != "Autumn")
            {
                price -= price * 0.05;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
            }
        }
    }
}