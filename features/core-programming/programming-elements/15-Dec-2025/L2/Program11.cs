using System;

class SimpleInterest
{
    public static void Run()
    {
        Console.Write("Enter principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter time: ");
        double time = double.Parse(Console.ReadLine());

        double interest = (principal * rate * time) / 100;

        Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
