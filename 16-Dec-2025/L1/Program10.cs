using System;

	public class WhileInput0
	{
		public static void Run()
		{
		Console.WriteLine("Enter a number- ");
		double Number = double.Parse(Console.ReadLine());
		double Total = 0.0;

		while(Number != 0)
		{
			Total += Number;
            Console.WriteLine("Enter a number- ");
            Number = double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Total Sum = {Total}");


    }
}

