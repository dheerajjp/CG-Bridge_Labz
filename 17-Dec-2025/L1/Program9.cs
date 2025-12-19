using System;

	public class CopyArray
	{
		public static void Run()
		{

		Console.WriteLine("Enter number of rows");
		int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of columns");
        int columns = int.Parse(Console.ReadLine());

		int Index = 0; 

		int[,] Multidim = new int[rows, columns];
        Console.WriteLine($"Enter element- ");

        for (int i = 0; i<rows; i++)
		{
			for(int j = 0; j<columns; j++)
			{

				Multidim[i, j] = int.Parse(Console.ReadLine());
			}
		}

		int[] Arr = new int[rows * columns];
		for(int i = 0; i<rows; i++)
		{
			for(int j =0; j<columns; j++)
			{

				Arr[Index] = Multidim[i, j];
				Index++;
            }
        }
		for (int i = 0; i < Index; i++)
		{
			Console.Write($" {Arr[i]} ");
		}
    }
}


