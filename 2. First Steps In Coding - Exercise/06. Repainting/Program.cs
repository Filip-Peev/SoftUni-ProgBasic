using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double materials = (nylon + 2) * 1.5 + (paint + paint * 0.1) * 14.5 + thinner * 5 + 0.40;
            double workers = materials * 0.3 * hours;
            Console.WriteLine(materials + workers);
        }
    }
}