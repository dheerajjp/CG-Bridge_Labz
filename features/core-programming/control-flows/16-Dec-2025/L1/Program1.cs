using System;

	public class Divisible
	{
		public static void Run()
		{
		Console.WriteLine("Enter number: ");
		int number = int.Parse(Console.ReadLine());

		if (number % 5 == 0)
		{
            Console.WriteLine($"Is the number {number} divisible by 5? Yes");

        }
		else
		{
            Console.WriteLine($"Is the number {number} divisible by 5? No");
        }




    }
}

