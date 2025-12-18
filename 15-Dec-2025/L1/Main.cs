using System;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which program?");
        var choice = Console.ReadLine();

        if (choice == "1")
            AgeOfHari.Run();

        else if (choice == "2")
            Averagemark.Run();

        else if (choice == "3")
            kmToMiles.Run();

        else if (choice == "4")
            profit.Run();

        else if (choice == "5")
            DividePens.Run();

        else if (choice == "6")
            FeeDiscount.Run();

        else if (choice == "7")
            EarthVolume.Run();

        else if (choice == "8")
            KmToMilesTwo.Run();

        else if (choice == "9")
            FeeDiscountInput.Run();

        else if (choice == "10")
            HeightConversion.Run();

        else if (choice == "11")
            Calculator.Run();

        else if (choice == "12")
            TriangleArea.Run();

        else if (choice == "13")
            SquareSide.Run();

        else if (choice == "14")
            FeetConversion.Run();

        else if (choice == "15")
            PurchasePrice.Run();

        else if (choice == "16")
            Handshakes.Run();
    }
}
