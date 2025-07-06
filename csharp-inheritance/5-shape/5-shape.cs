using System;

/// <summary>
/// Base class Shape
/// </summary>
public class Shape
{
    /// <summary>
    /// Virtual method Area() to be overridden by derived classes
    /// </summary>
    /// <returns>Throws NotImplementedException</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }

}