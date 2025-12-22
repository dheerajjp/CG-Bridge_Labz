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


                case 3:
                    Multiples.Run();
                    break;

                case 4:
                    IndexTo10.Run();
                    break;

                case 5:
                    SixToNine.Run();
                    break;

                case 6:
                    PlayerHeight.Run();
                    break;

                case 7:
                    EvenOrOdd.Run();
                    break;

                case 8:
                    Factors.Run();
                    break;

                case 9:

                    CopyArray.Run();
                    break;


            }

            
         }
        if (n == 2)
        {
            Console.WriteLine("Enter choice of program");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    Bonus.Run();
                    break;

                case 2:
                    AgeAndHeight.Run();
                    break;

                case 3:
                    SumOfDigits.Run();
                    break;
            }
         }
    }
}