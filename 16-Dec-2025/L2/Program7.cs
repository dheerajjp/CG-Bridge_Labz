using System;

class FriendsInfo
{
    public static void Run()
    {
        Console.WriteLine("Enter Amar's age:");
        int amarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Amar's height:");
        int amarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Akbar's age:");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Akbar's height:");
        int akbarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Anthony's age:");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Anthony's height:");
        int anthonyHeight = int.Parse(Console.ReadLine());

        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));

        Console.WriteLine("Youngest Age: " + youngestAge);
        Console.WriteLine("Tallest Height: " + tallestHeight);
    }
}
