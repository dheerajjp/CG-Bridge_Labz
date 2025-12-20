using System;

class FeeDiscountInput
{
    public static void Run()
    {
        Console.Write("Enter fee: ");
        double fee = double.Parse(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        double discountPercent = double.Parse(Console.ReadLine());

        double discountAmount = fee * discountPercent / 100;
        double finalFee = fee - discountAmount;

        Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalFee}");
    }
}
