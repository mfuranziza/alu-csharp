using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        if (list1 == null || list2 == null)
            return new List<int>();
        
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> commonElements = new HashSet<int>();
        
        foreach (int element in list2)
        {
            if (set1.Contains(element))
            {
                commonElements.Add(element);
            }
        }
        
        List<int> result = new List<int>();
        foreach (int element in commonElements)
        {
            result.Add(element);
        }
        
        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - 1 - i; j++)
            {
                if (result[j] > result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }
        
        return result;
    }
}