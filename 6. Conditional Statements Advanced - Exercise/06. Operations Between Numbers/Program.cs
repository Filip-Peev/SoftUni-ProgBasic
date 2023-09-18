using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            string evenOrOdd = "";

            switch (sign)
            {
                case '+':
                    if ((num1 + num2) % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2} - {evenOrOdd}");
                    break;
                case '-':
                    if ((num1 - num2) % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2} - {evenOrOdd}");
                    break;
                case '*':
                    if ((num1 * num2) % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2} - {evenOrOdd}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        double num1Double = num1;
                        double num2Double = num2;
                        Console.WriteLine($"{num1} / {num2} = {num1Double / num2Double:F2}");
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}