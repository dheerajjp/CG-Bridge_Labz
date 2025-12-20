using System;

class LargestNumberCheck
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        bool isFirstLargest =
            firstNumber > secondNumber &&
            firstNumber > thirdNumber;

        bool isSecondLargest =
            secondNumber > firstNumber &&
            secondNumber > thirdNumber;

        bool isThirdLargest =
            thirdNumber > firstNumber &&
            thirdNumber > secondNumber;

        Console.WriteLine("Is the first number the largest? " + isFirstLargest);
        Console.WriteLine("Is the second number the largest? " + isSecondLargest);
        Console.WriteLine("Is the third number the largest? " + isThirdLargest);
    }
}
