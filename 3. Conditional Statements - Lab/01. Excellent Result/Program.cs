using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double text = double.Parse(Console.ReadLine());
            if (text >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}