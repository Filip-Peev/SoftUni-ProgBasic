using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (n < 100)
            {
                bonus = bonus + 5;
            }
            else if (n > 1000)
            {
                bonus = bonus + n * 10.0 / 100;
            }
            else
            {
                bonus = bonus + n * 20.0 / 100;
            }

            bool even = n % 2 == 0;
            if (even)
            {
                bonus = bonus + 1;
            }
            int m = n % 10;
            if (m == 5)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(n + bonus);
        }
    }
}