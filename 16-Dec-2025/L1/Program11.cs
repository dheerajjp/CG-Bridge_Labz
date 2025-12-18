using System;

	public class WhileInput0orNegative
{
		public static void Run()
		{
		
		double total = 0.0;

		while (true)
		{
            Console.WriteLine("Enter number - ");
            double Number = double.Parse(Console.ReadLine());
			if (Number <= 0)
			{
				break;
					}

			else {
                total += Number;
                
            }
				
            }
        Console.WriteLine($"Total Sum = {total}");


    }


}
		


