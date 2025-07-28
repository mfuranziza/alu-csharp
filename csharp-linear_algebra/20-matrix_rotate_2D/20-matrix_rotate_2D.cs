using System;

/// <summary>
/// Provides mathematical operations for matrices
/// </summary>

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Validate input matrix size
        if (cols != 2 || rows < 1)
            return new double[,] { { -1 } };

        double[,] result = new double[rows, 2];
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            // Apply rotation transformation
            double rotatedX = x * cos - y * sin;
            double rotatedY = x * sin + y * cos;

            // Round only final results
            result[i, 0] = Math.Round(rotatedX, 2, MidpointRounding.AwayFromZero);
            result[i, 1] = Math.Round(rotatedY, 2, MidpointRounding.AwayFromZero);
        }

        return result;
    }
}
