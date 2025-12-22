using System;

	public class AgeAndHeight
	{
		public static void Run()
		{

        int[] age = new int[3];
        double[] height = new double[3];

        int youngest = age[0];
		double tallest = height[0];

		for(int i = 0; i<3; i++)
		{
			
			Console.WriteLine($"Enter the age of friend {i + 1}- ");
			age[i] = int.Parse(Console.ReadLine());

			Console.WriteLine($"Enter height of friend {i + 1}");
			height[i] = double.Parse(Console.ReadLine());

        }
		for(int i = 1; i<3; i++)
		{
			if (age[i] < youngest)
			{
				youngest = age[i];
			}
			if (height[i] > tallest)
			{
				tallest = height[i];

			}
		}

		Console.WriteLine($"Youngest is - {youngest}");

        Console.WriteLine($"Tallest is - {tallest}");

    }
}


