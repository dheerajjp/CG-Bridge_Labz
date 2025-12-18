using System;

class TriangleArea
{
    public static void Run()
    {
        Console.Write("Enter base: ");
        double baseValue = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double areaCm = 0.5 * baseValue * height;
        double areaInches = areaCm / 6.4516;

        Console.WriteLine($"Area in square cm is {areaCm} and square inches is {areaInches}");
    }
}
