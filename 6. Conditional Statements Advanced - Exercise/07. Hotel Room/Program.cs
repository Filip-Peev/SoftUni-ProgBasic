using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = nights * 50.0;
                    apartmentPrice = nights * 65.0;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        studioPrice *= 0.70;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = nights * 75.20;
                    apartmentPrice = nights * 68.70;
                    if (nights > 14)
                    {
                        studioPrice *= 0.80;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = nights * 76;
                    apartmentPrice = nights * 77;
                    break;
                default:
                    break;
            }
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }
            Console.WriteLine($"Apartment: {(apartmentPrice):F2} lv.");
            Console.WriteLine($"Studio: {(studioPrice):F2} lv.");
        }
    }
}