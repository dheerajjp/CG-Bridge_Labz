using System;

	public class Bonus
	{
		public static void Run()
		{
        double[] Salary = new double[10];
        double[] Years = new double[10];
		double[] NewSalary = new double[10];
		double[] bonus = new double[10];
		double totalbonus = 0;
        double oldsal = 0;
		double newsal = 0;

        for (int i = 0; i<10; i++)
		{
			Console.WriteLine($"Enter salaray of employee {i+1}");
			Salary[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter years of employee {i + 1}");
            Years[i] = int.Parse(Console.ReadLine());

			if (Years[i] >= 5)
			{
				bonus[i] = Salary[i] * 0.005;
                NewSalary[i] = Salary[i] + bonus[i];


            }
            else {
                bonus[i] = Salary[i] * 0.002;
                NewSalary[i] = Salary[i] + bonus[i];

            }
			
        }
		for(int i = 0; i< 10; i++)
		{
			oldsal += Salary[i];
			newsal += NewSalary[i];
            totalbonus += bonus[i];

        }
		for(int i = 0; i<10; i++)
		{
			Console.WriteLine($"total bonus of employee {i} is- {totalbonus} and total old salary is - {oldsal}, new salary is - {newsal}");
		}
		
		}
	}


