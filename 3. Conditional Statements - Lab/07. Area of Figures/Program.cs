using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double result = side * side;
                Console.WriteLine($"{result:F3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double result = sideA * sideB;
                Console.WriteLine($"{result:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = Math.PI * (radius * radius);
                Console.WriteLine($"{result:F3}");
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double result = (side * height) / 2;
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}