using System;

class MainProgram
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter Level - ");
        int n = int.Parse(Console.ReadLine());

        if(n == 1)
        {

            Console.WriteLine("Enter choice of program");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    Vote.Run();
                    break;

                case 2:
                    EvenOdd.Run();
                    break;

            }
            
            }
    }
}