using System;

	public class Multiples
	{
		public static void Run()
		{
		Console.WriteLine("Enter a number to be multiplied from 1-10 ");
		int Number = int.Parse(Console.ReadLine());

		int[] Multiples = new int[10];

		for(int i = 1; i < Multiples.Length +1; i++)
		{
			Multiples[i] = Number * i;
		}
		for(int i = 1; i< Multiples.Length +1; i++)
		{
			Console.WriteLine($"{Number} * {i} = {Multiples[i]}");
		}


		}
	
}

