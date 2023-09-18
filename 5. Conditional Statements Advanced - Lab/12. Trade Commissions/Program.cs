using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double commission = 0.0;

            switch (town)
            {
                case "Sofia":
                    if (sells > 0 && sells < 500)
                    {
                        commission = sells * 0.05;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commission = sells * 0.07;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commission = sells * 0.08;
                    }
                    else if (sells > 10000)
                    {
                        commission = sells * 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    break;
                case "Varna":
                    if (sells > 0 && sells <= 500)
                    {
                        commission = sells * 0.045;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commission = sells * 0.075;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commission = sells * 0.10;
                    }
                    else if (sells > 10000)
                    {
                        commission = sells * 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    break;
                case "Plovdiv":
                    if (sells > 0 && sells <= 500)
                    {
                        commission = sells * 0.055;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commission = sells * 0.08;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commission = sells * 0.12;
                    }
                    else if (sells > 10000)
                    {
                        commission = sells * 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (commission != 0)
            {
                Console.WriteLine("{0:F2}", commission);
            }
        }
    }
}