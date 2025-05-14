using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                result.Append(i.ToString());
                result.Append(j.ToString());

                if (!(i == 8 && j == 9))
                {
                    result.Append(", ");
                }
            }
        }

        Console.WriteLine(result.ToString());
    }
}
