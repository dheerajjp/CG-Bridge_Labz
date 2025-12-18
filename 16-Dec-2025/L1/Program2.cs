using System;

class SmallestNumberCheck
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        bool isFirstSmallest =
            firstNumber < secondNumber &&
            firstNumber < thirdNumber;

        Console.WriteLine("Is the first number the smallest? " + isFirstSmallest);
    }
}

