/*
 This code is writen by stoyan06
 */
using System;

namespace P03_MilesToKilometers
{
    public class P03_MilesToKilometers
    {
        public static void Main(string[] args)
        {
            /* We recieve the distance in miles from the console */
            var distInMiles = double.Parse(Console.ReadLine());

            /* The distance in kilometers for one mile */
            const double kmPerMile = 1.60934;

            /* Calculate the distance from miles to kilometers */
            var distanceInKilometers = distanceInMiles * kilometersPerMile;

            /* Print the distance in kilometers on the console. */
            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}