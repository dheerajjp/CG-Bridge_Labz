using System;

class KmToMilesTwo
{
    public static void Run()
    {
        Console.Write("Enter distance in km: ");
        double km = double.Parse(Console.ReadLine());

        double miles = km / 1.6;

        Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
    }
}
