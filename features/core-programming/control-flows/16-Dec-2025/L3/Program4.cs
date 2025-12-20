using System;

class AbundantNumber
{
    public static void Run()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        if (sum > number)
            Console.WriteLine("The number is an Abundant Number");
        else
            Console.WriteLine("The number is NOT an Abundant Number");
    }

}
