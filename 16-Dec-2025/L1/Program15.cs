using System;

public class FactorialFor
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Please enter a natural number");
            return;
        }

        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of " + number + " is " + factorial);
    }
}
