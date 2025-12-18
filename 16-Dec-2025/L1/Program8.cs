using System;
	public class RocketLaunch
	{
		public static void Run()
		{
		Console.Write("Enter Countdown number: ");
		int Count = int.Parse(Console.ReadLine());

		while(Count> 1)
		{
			Count--;
            Console.Write($"T-Minus {Count} seconds left..\n");
        }
        Console.Write("Launch!");

    }
}


