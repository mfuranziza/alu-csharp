using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (c != 'q' && c != 'e')
                    output += c;
            }
            
            Console.Write(output);
        }
    }
}