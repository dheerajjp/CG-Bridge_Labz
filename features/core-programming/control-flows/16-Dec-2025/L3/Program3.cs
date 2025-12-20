using System;

class HarshadNumber
{
    public static void Run()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number = number / 10;
        }

        if (originalNumber % sum == 0)
            Console.WriteLine("The number is a Harshad Number");
        else
            Console.WriteLine("The number is NOT a Harshad Number");
    }

}
