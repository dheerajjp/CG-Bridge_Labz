using System;

	public class SumOfDigits
	{
		public static void Run()
		{

		Console.WriteLine("Enter nuber - ");
		int number = int.Parse(Console.ReadLine());
		
		int digit = 0;

		int maxdigit = 10;

		int[] arr = new int[maxdigit];

		int index = 0;

		while(number != 0 && index !< maxdigit)
		{
			arr[index] = number %= 10;
			number /= 10;
			index++;
		}

		int largest = 0, secl = 0;

		for(int i =0; i<digit. ){

		}
	}


