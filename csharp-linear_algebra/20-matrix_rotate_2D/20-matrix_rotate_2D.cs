using System;

/// <summary>
/// Provides mathematical operations for matrices
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a 2D matrix by a given angle in radians
    /// </summary>
    /// <param name="matrix">The 2D matrix to rotate (must have exactly 2 columns representing x,y coordinates)</param>
    /// <param name="angle">The angle in radians to rotate by</param>
    /// <returns>A new matrix with rotated values, or a matrix containing -1 if the input matrix is invalid</returns>
    /// <remarks>
    /// This method applies rotation to the VALUES of each element in the matrix, not the positions.
    /// Each row represents a point (x, y) that gets rotated using the rotation matrix formula:
    /// x' = x * cos(angle) - y * sin(angle)
    /// y' = x * sin(angle) + y * cos(angle)
    /// </remarks>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if matrix is null
        if (matrix == null)
            return new double[,] { { -1 } };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Invalid matrix check - must have exactly 2 columns and at least 1 row
        if (cols != 2 || rows < 1)
            return new double[,] { { -1 } };

        double[,] result = new double[rows, 2];
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            // Apply 2D rotation transformation
            double rotatedX = x * cos - y * sin;
            double rotatedY = x * sin + y * cos;

            // Handle floating-point precision by rounding to more precision first, then to 2 decimals
            rotatedX = Math.Round(rotatedX, 10);
            rotatedY = Math.Round(rotatedY, 10);

            result[i, 0] = Math.Round(rotatedX, 2, MidpointRounding.AwayFromZero);
            result[i, 1] = Math.Round(rotatedY, 2, MidpointRounding.AwayFromZero);
        }

        return result;
    }
}