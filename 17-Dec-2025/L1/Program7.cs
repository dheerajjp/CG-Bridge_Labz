using System;
	public class EvenOrOdd
	{
		public static void Run()
		{
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		int size = number / 2 + 1;

        int[] Even = new int[size];
        int[] Odd = new int[size];

		int indexeven = 0;
		int indexodd = 0;

		for(int i = 0; i<number; i++)
		{
            Console.WriteLine($"Enter {i+1 }th element of Array: ");
			int element = int.Parse(Console.ReadLine());

			if (element % 2 == 0)
			{
				Even[indexeven] = element;
				indexeven++;
			}
			else {
                Odd[indexodd] = element;
                indexodd++;
            }
        }
		for (int i = 0; i<indexeven; i++)
		{
			Console.Write($"{Even[i]} ");
		}
		Console.WriteLine();
        for (int i = 0; i < indexodd; i++)
        {
            Console.Write($"{Odd[i]} ");
        }


    }
}


