using System;

class BMI
{
    public static void Run()
    {
        Console.WriteLine("Enter weight in kg:");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height in cm:");
        double heightCm = double.Parse(Console.ReadLine());

        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);

        Console.WriteLine("BMI: " + bmi);
    }
}
