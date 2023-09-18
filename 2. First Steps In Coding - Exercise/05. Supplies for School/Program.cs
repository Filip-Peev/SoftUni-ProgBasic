using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaning = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double sum = pens * 5.80 + markers * 7.20 + cleaning * 1.20;
            discount = discount / 100;
            Console.WriteLine(sum - sum * discount);
        }
    }
}