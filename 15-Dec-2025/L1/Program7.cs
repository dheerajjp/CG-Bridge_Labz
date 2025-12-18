using System;

class EarthVolume
{
    public static void Run()
    {
        double radiusKm = 6378;
        double pi = Math.PI;

        double volumeKm = (4.0 / 3.0) * pi * Math.Pow(radiusKm, 3);
        double volumeMiles = volumeKm * 0.239913;

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm} and cubic miles is {volumeMiles}");
    }
}
