using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int monthsOfDeposit = int.Parse(Console.ReadLine());
            double interestForYear = double.Parse(Console.ReadLine());

            double interestPerMonth = depositAmount * (interestForYear / 100) / 12;

            Console.WriteLine(depositAmount + monthsOfDeposit * interestPerMonth);
        }
    }
}