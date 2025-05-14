using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int number = rand.Next(-10, 11);

        if (number > 0)
        {
            Console.WriteLine($"{number} is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine($"{number} is zero");
        }
        else
        {
            Console.WriteLine($"{number} is negative");
        }
    }
}
