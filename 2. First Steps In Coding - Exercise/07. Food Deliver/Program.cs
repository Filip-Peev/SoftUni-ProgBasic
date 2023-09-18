using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chicken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double vegetarian = double.Parse(Console.ReadLine());

            double sum = chicken * 10.35 + fish * 12.40 + vegetarian * 8.15;
            double desert = sum * 0.2;
            Console.WriteLine(sum + desert + 2.5);
        }
    }
}