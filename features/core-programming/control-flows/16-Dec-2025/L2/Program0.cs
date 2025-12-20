using System;

	public class Leapyear
	{
		public static void Run()
		{

		Console.Write("Enter Year -");
		int Year = int.Parse(Console.ReadLine());

		if (Year < 1582)
		{
			Console.Write("NO CALENDAR AVAILABLE");
		}
		else { 
			if(Year % 4 == 0)
			{
				if(Year % 400 == 0)
				{
                    Console.Write("This is a leap year!");
                }
				else if (Year % 100 == 0)
				{
                    Console.Write("Not a leap year");

                }

            }
			else
			{
                Console.Write("Not a leap year");

            }
        }

		

    }
}


