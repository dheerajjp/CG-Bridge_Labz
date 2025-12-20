using System;

class PrimeCheck
{
    public static void Run()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = number > 1;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }
}
