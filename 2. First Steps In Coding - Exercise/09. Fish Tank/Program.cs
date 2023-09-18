using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double size = lenght * width * heigh / 1000;
            percent /= 100;

            Console.WriteLine(size * (1 - percent));
        }
    }
}