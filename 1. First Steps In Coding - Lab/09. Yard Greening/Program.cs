using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double sum = meters * 7.61;
            double discount = sum * 0.18;
            Console.WriteLine($"The final price is: {sum - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}