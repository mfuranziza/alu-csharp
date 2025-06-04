using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aQueue.Count);
        
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: " + aQueue.Peek());
        }
        
        aQueue.Enqueue(newItem);
        
        bool contains = false;
        foreach (string item in aQueue)
        {
            if (item == search)
            {
                contains = true;
                break;
            }
        }
        
        Console.WriteLine("Queue contains \"" + search + "\": " + contains);
        
        if (contains)
        {
            string[] items = new string[aQueue.Count];
            aQueue.CopyTo(items, 0);
            aQueue.Clear();
            
            int searchIndex = -1;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == search)
                {
                    searchIndex = i;
                    break;
                }
            }
            
            for (int i = searchIndex + 1; i < items.Length; i++)
            {
                aQueue.Enqueue(items[i]);
            }
        }
        
        return aQueue;
    }
}