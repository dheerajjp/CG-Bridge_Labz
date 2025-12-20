using System;

	public class Countdown
	{
		public static void Run()
		{
		Console.Write("Countdown begins now: ");

		int Count = int.Parse(Console.ReadLine());

		for(int i = Count; i >= 1; i--)
		{
            Console.WriteLine($"{i} seconds remaining.");

        }

    }
}


