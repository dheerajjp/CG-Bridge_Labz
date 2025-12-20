using System;

	public class EvenOdd
	{
		public static void Run()
		{
		int[] nums = new int[5];

		for(int i = 0; i < nums.Length; i++)
		{

			Console.WriteLine($"Enter element {i + 1}: ");
			nums[i] = int.Parse(Console.ReadLine());
		}
		for(int i = 0; i < nums.Length; i++)
		{
			if (nums[i] < 0) {
				Console.WriteLine($"Number {nums[i]} negative.");

			}
			else if (nums[i] == 0)
			{
				Console.WriteLine($"Number {nums[i]} zero.");
			}
			else
			{
				if (nums[i] %2 == 0)
				{
					Console.WriteLine($"Number {nums[i]} even.");
				}
				else
				{
					Console.WriteLine($"Number {nums[i]} odd.");
				}
			}

		
		}
        if (nums[0] == nums[nums.Length - 1])
        {
            Console.WriteLine("Elements are same!");
        }
        else
        {
            Console.WriteLine("Elements are not same!");
        }


    }
	}


