using System;

class GradeCalculator
{
    public static void Run()
    {
        Console.WriteLine("Enter Physics marks:");
        int physics = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Chemistry marks:");
        int chemistry = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Maths marks:");
        int maths = int.Parse(Console.ReadLine());

        double average = (physics + chemistry + maths) / 3.0;

        Console.WriteLine("Average Marks: " + average);

        if (average >= 75)
            Console.WriteLine("Grade: A");
        else if (average >= 60)
            Console.WriteLine("Grade: B");
        else if (average >= 40)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: Fail");
    }
}
