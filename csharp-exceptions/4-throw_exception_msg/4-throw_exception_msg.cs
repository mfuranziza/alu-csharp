﻿using System;

public static class Except
{
    public static void ThrowMsg(string msg)
    {
        throw new Exception(msg);
    }
}