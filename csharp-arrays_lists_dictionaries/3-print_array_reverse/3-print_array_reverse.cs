using System;

#nullable enable

class Array
{

    

    public static void Reverse(int[] array)
    {
        

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array == null || array.Length == 0)
        {
            Console.WriteLine(array[i]);
            return;
        }
            Console.Write(array[i]);
            if (i > 0)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}