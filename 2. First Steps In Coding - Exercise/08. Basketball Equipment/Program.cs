using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double year = double.Parse(Console.ReadLine());

            double sneakers = year - year * 0.4;
            double clothes = sneakers - sneakers * 0.2;
            double ball = clothes * 0.25;
            double accessories = ball * 0.2;

            Console.WriteLine(year + sneakers + clothes + ball + accessories);
        }
    }
}