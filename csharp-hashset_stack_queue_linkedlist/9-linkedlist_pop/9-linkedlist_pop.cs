using System;
using System.Collections.Generic;

public class LList
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(11);
        myLList.AddLast(3);
        myLList.AddLast(-9);
        myLList.AddLast(47);
        myLList.AddLast(0);
        myLList.AddLast(-9);

        Console.WriteLine(LList.Pop(myLList));
    }

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
}