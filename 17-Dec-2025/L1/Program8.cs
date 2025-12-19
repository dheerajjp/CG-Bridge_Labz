using System;
	public class Factors
	{
		public static void Run()
		{

		Console.WriteLine("Enter a number to find its factors- ");
		int number = int.Parse(Console.ReadLine());

		int[] Arr = new int[10];
		int size = Arr.Length;
		int index = 0;

		for(int i = 0; i <number; i++)
		{
			if(number%i == 0)
			{
				Arr[index] = i;
				index++;
				if(index == 10)
				{
					Array.Resize(ref Arr, (size * 2));
				}
			}
			else
			{
				continue;
			}

		}
		for(int i = 0; i < size; i++)
		{
			Console.WriteLine($"{Arr[i]} ");


        }

    }
}


