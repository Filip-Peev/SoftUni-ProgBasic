﻿using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {projectsCount * 3} hours to complete {projectsCount} project/s.");
        }
    }
}