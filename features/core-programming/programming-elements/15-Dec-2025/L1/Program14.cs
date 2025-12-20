using System;

class FeetConversion
{
    public static void Run()
    {
        Console.Write("Enter distance in feet: ");
        double feet = double.Parse(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine($"Distance in yards is {yards} and in miles is {miles}");
    }
}
