using System;

class Character
{
    public static bool IsLower(char c)
    {
        // ASCII values for lowercase letters are in the range 97-122
        return c >= 'a' && c <= 'z';
    }
}