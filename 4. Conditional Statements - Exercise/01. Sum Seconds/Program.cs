using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeFirst = int.Parse(Console.ReadLine());
            int timeSecond = int.Parse(Console.ReadLine());
            int timeThird = int.Parse(Console.ReadLine());

            int sum = timeFirst + timeSecond + timeThird;

            int min = sum / 60;
            int sec = sum % 60;

            Console.Write(min);

            if (sec < 10)
            {
                Console.WriteLine(":0" + sec);
            }
            else
            {
                Console.WriteLine(":" + sec);
            }
        }
    }
}