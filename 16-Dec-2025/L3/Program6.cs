using System;

class SimpleCalculator
{
    public static void Run()
    {
        Console.WriteLine("Enter first number:");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /):");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;

            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;

            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;

            case "/":
                if (second != 0)
                    Console.WriteLine($"Result: {first / second}");
                else
                    Console.WriteLine("Division by zero not allowed");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
