using System;

class Handshakes
{
    public static void Run()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine($"The maximum number of handshakes is {handshakes}");
    }
}
