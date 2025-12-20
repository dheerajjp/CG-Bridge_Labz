using System;

	public class SixToNine
	{
		public static void Run()
		{

		Console.WriteLine("Enter multiplicaiton number: ");
		int input = int.Parse(Console.ReadLine());

		int[] Arr = new int[4];
		int index = 0;

		for(int i = 6; i <=  9; i++)
		{

			Arr[index] = input * i;
			index++;
			
		}

		index = 0;

		for(int i = 6; i<=9; i++)
		{
			Console.WriteLine($"Result of {input}*{i} is- {Arr[index]}");
			index++;
		}

		}
	}


