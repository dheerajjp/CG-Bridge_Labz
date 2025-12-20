using System;

class PowerOfNumber
{
    public static void Run()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the power:");
        int power = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        Console.WriteLine($"Result: {result}");
    }

}
