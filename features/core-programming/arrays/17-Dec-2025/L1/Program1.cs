using System;

	public class Vote
	{
		public static void Run()
		{
		int[] ages = new int[10];
		Console.WriteLine("Enter ages of students below -");

		for(int i = 0; i<ages.Length; i++)
		{
			Console.WriteLine($"Enter age of student {i + 1}: ");
			ages[i] = int.Parse(Console.ReadLine());

			if (ages[i] < 0)
			{
				Console.WriteLine("Invalid age");
			}
			else
			{
				if (ages[i] >= 18)
				{
					Console.WriteLine("Eligible to vote");
				}
				else
				{
					Console.WriteLine("Not eligible to vote");
				}
			}
		}
		
		}
	}


