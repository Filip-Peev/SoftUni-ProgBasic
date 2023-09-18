using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuCost = gpuCount * 250;
            double cpuCost = (gpuCost * 0.35) * cpuCount;
            double ramCost = (gpuCost * 0.10) * ramCount;

            double finalSum = gpuCost + cpuCost + ramCost;
            if (gpuCount > cpuCount)
            {
                finalSum = finalSum - (finalSum * 0.15);
            }
            if (budget >= finalSum)
            {
                Console.WriteLine($"You have {budget - finalSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalSum - budget:F2} leva more!");
            }
        }
    }
}
