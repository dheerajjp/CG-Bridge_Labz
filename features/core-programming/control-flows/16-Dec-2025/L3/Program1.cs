using System;

class ArmstrongNumber
{
    public static void Run()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit * digit * digit;
            number = number / 10;
        }

        if (sum == originalNumber)
            Console.WriteLine("The number is an Armstrong Number");
        else
            Console.WriteLine("The number is NOT an Armstrong Number");
    }

}
