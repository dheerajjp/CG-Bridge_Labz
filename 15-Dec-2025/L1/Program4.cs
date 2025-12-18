using System;

class profit
{
    public static void Run()
    {
        int costprice = 129;
        int sellingprice = 191;

        double profit = (sellingprice
             - costprice);
        double profitpercentage = (profit / costprice) *100;

        Console.WriteLine(
    "The Cost Price is " + costprice + " Rupees and Selling Price is " + sellingprice + " Rupees.\n" + "The Profit is " + profit + 
    " Rupees and the Profit Percentage is " + profitpercentage + " Rupees."
);


        
    }
}
