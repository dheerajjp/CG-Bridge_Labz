using System;

class Calculator
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Addition: {number1 + number2}");
        Console.WriteLine($"Subtraction: {number1 - number2}");
        Console.WriteLine($"Multiplication: {number1 * number2}");
        Console.WriteLine($"Division: {number1 / number2}");
    }
}
