using System;

public class FactorialWhile
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
        int counter = 1;

        while (counter <= number)
        {
            factorial *= counter;
            counter++;
        }

        Console.WriteLine("Factorial of " + number + " is " + factorial);
    }
}
