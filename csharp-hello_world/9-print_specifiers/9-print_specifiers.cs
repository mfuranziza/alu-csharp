using System;
class Program
{
    static void Main(string[] args)
    {
        double percent = 75.53;
        double currency = 98765.4321;
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Console.WriteLine("Percent: {0:0.00}%\nCurrency: {1:C}", percent, money);
    }
}