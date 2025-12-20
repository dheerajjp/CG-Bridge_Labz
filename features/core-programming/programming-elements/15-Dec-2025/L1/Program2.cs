using System;

class Averagemark
{
    public static void Run()
    {
        int mathsmark = 94;
        int chemmark = 95;
        int phymark = 96;

        double Averagemark = ((mathsmark + chemmark + phymark) / 300.0) *100;
        Console.WriteLine("Average mark is: " + Averagemark);

    }
}
