﻿using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string location = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    location = "Camp";
                    budget *= 0.3;
                }
                else if (season == "winter")
                {
                    location = "Hotel";
                    budget *= 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    location = "Camp";
                    budget *= 0.4;
                }
                else if (season == "winter")
                {
                    location = "Hotel";
                    budget *= 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer")
                {
                    location = "Hotel";
                    budget *= 0.9;
                }
                else if (season == "winter")
                {
                    location = "Hotel";
                    budget *= 0.9;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{location} - {budget:F2}");
        }
    }
}