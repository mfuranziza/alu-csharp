using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "C# is an elegant and type-safe object-oriented programming language that enables developers to build a variety of secure and robust applications that run on the .NET Framework.";
        Console.WriteLine(s.Substring(50, 27) + " in " + s.Substring(0, 2));
    }
}