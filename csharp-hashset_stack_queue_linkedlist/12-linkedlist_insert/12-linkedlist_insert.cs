using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list = new LinkedList<int>();
        
        if (size < 0)
        {
            return list;
        }
        
        for (int i = 0; i < size; i++)
        {
            list.AddLast(i);
            Console.WriteLine(i);
        }
        
        return list;
    }
    
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        
        foreach (int item in myLList)
        {
            count++;
        }
        
        return count;
    }
    
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        return myLList.AddFirst(n);
    }
    
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        
        foreach (int item in myLList)
        {
            if (item == value)
            {
                return index;
            }
            index++;
        }
        
        return -1;
    }
    
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == null || myLList.Count == 0 || myLList.First == null)
        {
            return 0;
        }
        
        int value = myLList.First.Value;
        myLList.RemoveFirst();
        return value;
    }
    
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList == null || n < 0)
        {
            return 0;
        }
        
        int index = 0;
        
        foreach (int item in myLList)
        {
            if (index == n)
            {
                return item;
            }
            index++;
        }
        
        return 0;
    }
    
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        
        foreach (int item in myLList)
        {
            sum += item;
        }
        
        return sum;
    }
    
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList == null)
        {
            return null;
        }
        
        if (myLList.Count == 0 || n <= myLList.First.Value)
        {
            return myLList.AddFirst(n);
        }
        
        LinkedListNode<int> current = myLList.First;
        
        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }
        
        return myLList.AddAfter(current, n);
    }
}