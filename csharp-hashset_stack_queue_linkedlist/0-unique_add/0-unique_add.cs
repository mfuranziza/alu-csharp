using System;
using System.Collections.Generic;
using System.Linq;

public class List
{
    public static int Sum(List<int> myList)
    {
        if (myList == null)
            return 0;
        HashSet<int> uniqueNumbers = new HashSet<int>(myList);
        
        int sum = 0;
        foreach (int number in uniqueNumbers)
        {
            sum += number;
        }
        
        return sum;
    }
}