﻿using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int division = list1[i] / list2[i];
                result.Add(division);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        
        return result;
    }
}