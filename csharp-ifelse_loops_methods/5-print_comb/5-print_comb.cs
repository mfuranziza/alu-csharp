using System;

class Program
{
    static void Main()
    {
        string result = "";
        for (int i = 0; i < 100; i++)
        {
            result += i.ToString("D2");
            if (i != 99)
                result += ", ";
        }
        Console.WriteLine(result);
    }
}
