using System;

class HeightConversion
{
    public static void Run()
    {
        Console.Write("Enter height in cm: ");
        double heightCm = double.Parse(Console.ReadLine());

        double totalInches = heightCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {feet} and {inches} inches");
    }
}
