using System;

	public class PlayerHeight
	{
		public static void Run()
		{

		double[] Heights = new double[11];
		double sum = 0;

		for(int i = 0; i < Heights.Length; i++)
		{
			Console.WriteLine($"Enter Height of player {i + 1}");
			Heights[i] = double.Parse(Console.ReadLine());
			sum += Heights[i];
        }

		Console.WriteLine($"Sum of al heights- {sum}");
		double mean = sum / 11;

        Console.WriteLine($"Mean of al heights- {mean}");


    }
}


