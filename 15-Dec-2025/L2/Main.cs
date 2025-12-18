using System;

class ProgramMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter program number (1–12):");
        var choice = Console.ReadLine();

        if (choice == "1")
            QuotientRemainder.Run();

        else if (choice == "2")
            IntOperation.Run();

        else if (choice == "3")
            DoubleOperation.Run();

        else if (choice == "4")
            CelsiusToFahrenheit.Run();

        else if (choice == "5")
            FahrenheitToCelsius.Run();

        else if (choice == "6")
            TotalIncome.Run();

        else if (choice == "7")
            SwapNumbers.Run();

        else if (choice == "8")
            TripDetails.Run();

        else if (choice == "9")
            TriangularPark.Run();

        else if (choice == "10")
            ChocolatesDistribution.Run();

        else if (choice == "11")
            SimpleInterest.Run();

        else if (choice == "12")
            WeightConversion.Run();

        else
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 12.");
    }
}
