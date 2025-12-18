using System;
namespace CG_Bridge_Labz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Level number: ");
            int n = int.Parse(Console.ReadLine());


            if(n == 1)
            {
                Console.WriteLine("=== Level 1 Programs ===");
                Console.Write("Enter program number: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Divisible.Run();
                        break;

                    case 2:
                        SmallestNumberCheck.Run();
                        break;

                    case 3:
                        LargestNumberCheck.Run();
                        break;

                    case 4:
                        NaturalNumberSum.Run();
                        break;

                    case 5:
                        VotingEligibility.Run();
                        break;

                    case 6:
                        NumberSignCheck.Run();
                        break;

                    case 7:
                        SpringSeason.Run();
                        break;

                    case 8:
                        RocketLaunch.Run();
                        break;

                    case 9:
                        Countdown.Run();
                        break;

                    case 10:
                        WhileInput0.Run();
                        break;

                    case 11:
                        WhileInput0orNegative.Run();
                        break;

                    case 12:
                        SumOfNaturalNumbersWhile.Run();
                        break;

                    case 13:
                        SumOfNaturalNumbersFor.Run();
                        break;

                    case 14:
                        FactorialWhile.Run();
                        break;

                    case 15:
                        FactorialFor.Run();
                        break;

                    case 16:
                        OddEvenNumbers.Run();
                        break;

                    case 17:
                        EmployeeBonus.Run();
                        break;

                    case 18:
                        MultiplicationTableSixToNine.Run();
                        break;




                    default:
                        Console.WriteLine("Invalid Level 1 program choice");
                        break;
                }

            }

            else if (n == 2)
            {
                Console.WriteLine("=== Level 2 Programs ===");
                Console.Write("Enter program number: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Leapyear.Run();
                        break;

                    case 2:
                        LeapYearSingleIf.Run();
                        break;

                    case 3:
                        GradeCalculator.Run();
                        break;

                    case 4:
                        PrimeCheck.Run();
                        break;

                    case 5:
                        FizzBuzzFor.Run();
                        break;

                    case 6:
                        FizzBuzzWhile.Run();
                        break;

                    case 7:
                        BMI.Run();
                        break;

                    case 8:
                        FriendsInfo.Run();
                        break;

                    case 9:
                        GreatestFactor.Run();
                        break;

                    case 10:
                        PowerOfNumber.Run();
                        break;

                    default:
                        Console.WriteLine("Invalid program number");
                        break;
                }
            


            }
            else if (n == 3)
            {
                Console.WriteLine("=== Level 3 Programs ===");
                Console.Write("Enter program number: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ArmstrongNumber.Run();
                        break;

                    case 2:
                        DigitCount.Run();
                        break;

                    case 3:
                        HarshadNumber.Run();
                        break;

                    case 4:
                        AbundantNumber.Run();
                        break;

                    case 5:
                        DayOfWeekCalculator.Run();
                        break;

                    case 6:
                        SimpleCalculator.Run();
                        break;

                    default:
                        Console.WriteLine("Invalid program number");
                        break;
                }

            }


            else
            {
                Console.WriteLine("\nExecution completed.");
            }

            
        }
    }
}
