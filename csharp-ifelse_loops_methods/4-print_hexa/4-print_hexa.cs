﻿using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            
            for (int i = 0; i <= 98; i++)
            {
                output += $"{i} = 0x{i:x}\n";
            }
            
            Console.Write(output);
        }
    }
}