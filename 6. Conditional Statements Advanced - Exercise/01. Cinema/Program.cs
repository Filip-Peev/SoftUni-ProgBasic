using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieТheater = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            switch (movieТheater)
            {
                case "Premiere":
                    income = rows * columns * 12.0;
                    break;
                case "Normal":
                    income = rows * columns * 7.5;
                    break;
                case "Discount":
                    income = rows * columns * 5;
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}