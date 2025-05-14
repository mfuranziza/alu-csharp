using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# is an elegant and type-safe object-oriented programming language that enables developers to build a variety of secure and robust applications that run on the .NET Framework.";
        Console.WriteLine(str.Substring(50, 27) + " in " + str.Substring(0, 2));
    }
}