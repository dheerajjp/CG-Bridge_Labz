using System;

public class SumOfNaturalNumbersWhile
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("The number is not a natural number");
            return;
        }

        int sumUsingWhile = 0;
        int counter = 1;

        while (counter <= number)
        {
            sumUsingWhile += counter;
            counter++;
        }

        int sumUsingFormula = number * (number + 1) / 2;

        Console.WriteLine("Sum using while loop: " + sumUsingWhile);
        Console.WriteLine("Sum using formula: " + sumUsingFormula);

        Console.WriteLine(
            "Both results are equal: " + (sumUsingWhile == sumUsingFormula)
        );
    }
}
