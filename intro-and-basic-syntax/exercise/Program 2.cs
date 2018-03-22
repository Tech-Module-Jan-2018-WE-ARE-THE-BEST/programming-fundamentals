using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var result = (width * height);
            Console.WriteLine($"{result:F2}");
        }
    }
}
