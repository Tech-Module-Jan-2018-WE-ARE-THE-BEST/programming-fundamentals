﻿using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// reading from the console
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
			//calculating the result
            var area = (width * height);
			//writing the result 
            Console.WriteLine($"{area:F2}");
        }
    }
}
