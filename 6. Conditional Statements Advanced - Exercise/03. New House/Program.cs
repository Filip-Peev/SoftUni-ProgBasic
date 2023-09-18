using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0.0;

            switch (flowerType)
            {
                case "Roses":
                    price = flowerCount * 5.0;
                    if (flowerCount > 80)
                    {
                        price -= price * 0.10;
                    }
                    break;
                case "Dahlias":
                    price = flowerCount * 3.80;
                    if (flowerCount > 90)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = flowerCount * 2.80;
                    if (flowerCount > 80)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = flowerCount * 3.0;
                    if (flowerCount < 120)
                    {
                        price += price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = flowerCount * 2.50;
                    if (flowerCount < 80)
                    {
                        price += price * 0.20;
                    }
                    break;
                default:
                    break;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
        }
    }
}