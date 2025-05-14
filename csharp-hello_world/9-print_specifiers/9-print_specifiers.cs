// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double percent = 75.53;
        double money = 98765.4321;
        
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Console.WriteLine("Percent: {0:0.00}%", percent);
        Console.WriteLine("Currency: {0:C}", money);
    }
}