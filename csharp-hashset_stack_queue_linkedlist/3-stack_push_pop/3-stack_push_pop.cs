using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }
        
        bool contains = false;
        foreach (string item in aStack)
        {
            if (item == search)
            {
                contains = true;
                break;
            }
        }
        
        Console.WriteLine("Stack contains \"" + search + "\": " + contains);
        
        if (contains)
        {
            Stack<string> tempStack = new Stack<string>();
            string[] items = new string[aStack.Count];
            aStack.CopyTo(items, 0);
            
            aStack.Clear();
            
            bool foundSearch = false;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == search)
                {
                    foundSearch = true;
                    break;
                }
                if (!foundSearch)
                {
                    tempStack.Push(items[i]);
                }
            }
            
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }
        
        aStack.Push(newItem);
        
        return aStack;
    }
}