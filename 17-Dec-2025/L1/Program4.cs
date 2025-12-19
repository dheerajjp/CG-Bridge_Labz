using System;

	public class IndexTo10
	{
		public static void Run()
		{
		double[] Arr = new double[10];
		double total = 0.0;
		int index = 0;

		

		while (true)
		{

            Console.WriteLine("Enter number - ");
            int value = int.Parse(Console.ReadLine());
            if (value == 0)
			{
				break;
			}
			else if (index == 10)
			{
				break;
			}
			else
			{
				Arr[index] = value;
				index++;
			}
		}
		for(int i = 0; i< index; i++)
		{
			total += Arr[i];
		}

		Console.WriteLine($"Total value is- {total}");
	}
}


