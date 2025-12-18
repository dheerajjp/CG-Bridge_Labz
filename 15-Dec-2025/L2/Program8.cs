using System;

class TripDetails
{
    public static void Run()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from start to via (miles): ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Enter distance from via to destination (miles): ");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.Write("Enter time taken (hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine($"The results of the trip are: {totalDistance} miles, {timeTaken} hours, {averageSpeed} mph");
    }
}
