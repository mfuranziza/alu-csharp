using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();
        
        if (list1 != null)
        {
            foreach (int element in list1)
            {
                bool found = false;
                if (list2 != null)
                {
                    foreach (int element2 in list2)
                    {
                        if (element == element2)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                
                if (!found && !result.Contains(element))
                {
                    result.Add(element);
                }
            }
        }
        
        if (list2 != null)
        {
            foreach (int element in list2)
            {
                bool found = false;
                if (list1 != null)
                {
                    foreach (int element1 in list1)
                    {
                        if (element == element1)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                
                if (!found && !result.Contains(element))
                {
                    result.Add(element);
                }
            }
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