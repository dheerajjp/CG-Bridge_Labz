using System;

public class SpringSeason
{
    public static void Run()
    {
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        bool isSpringSeason =
            (month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20);

        if (isSpringSeason)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
