using _2048Console.Classes;

namespace _2048Console.Application;

public class IntSquareMatrixTransformer
{
    public static IntSquareMatrix ShiftLeft(IntSquareMatrix matrix)
    {
        var size = matrix.Size;
        var transformedMatrix = IntSquareMatrix.Zeros(matrix.Size);
        int nonZeroIndex;

        for (int i = 0; i < size; i++)
        {
            nonZeroIndex = 0;

            for (int j = 0; j < size; j++)
            {
                if (matrix[i, j] != 0 && nonZeroIndex > 0 &&
                    matrix[i, j] == transformedMatrix[i, nonZeroIndex - 1])
                {
                    transformedMatrix[i, nonZeroIndex - 1] *= 2;
                }
                else if (matrix[i, j] != 0)
                {
                    transformedMatrix[i, nonZeroIndex++] = matrix[i, j];
                }
            }
        }

        return transformedMatrix;
    }

    public static IntSquareMatrix ShiftRight(IntSquareMatrix matrix)
    {
        var size = matrix.Size;
        var transformedMatrix = IntSquareMatrix.Zeros(matrix.Size);
        int nonZeroIndex;

        for (int i = size - 1; i >= 0; i--)
        {
            nonZeroIndex = size - 1;

            for (int j = size - 1; j >= 0; j--)
            {
                if (matrix[i, j] != 0 && nonZeroIndex < size - 1 &&
                    matrix[i, j] == transformedMatrix[i, nonZeroIndex + 1])
                {
                    transformedMatrix[i, nonZeroIndex + 1] *= 2;
                }
                else if (matrix[i, j] != 0)
                {
                    transformedMatrix[i, nonZeroIndex--] = matrix[i, j];
                }
            }
        }

        return transformedMatrix;
    }

    public static IntSquareMatrix ShiftUp(IntSquareMatrix matrix)
    {
        var size = matrix.Size;
        var transformedMatrix = IntSquareMatrix.Zeros(matrix.Size);
        int nonZeroIndex;

        for (int i = 0; i < size; i++)
        {
            nonZeroIndex = 0;

            for (int j = 0; j < size; j++)
            {
                if (matrix[j, i] != 0 && nonZeroIndex > 0 &&
                    matrix[j, i] == transformedMatrix[nonZeroIndex - 1, i])
                {
                    transformedMatrix[nonZeroIndex - 1, i] *= 2;
                }
                else if (matrix[j, i] != 0)
                {
                    transformedMatrix[nonZeroIndex++, i] = matrix[j, i];
                }
            }
        }

        return transformedMatrix;
    }

    public static IntSquareMatrix ShiftDown(IntSquareMatrix matrix)
    {
        var size = matrix.Size;
        var transformedMatrix = IntSquareMatrix.Zeros(matrix.Size);
        int nonZeroIndex;

        for (int i = size - 1; i >= 0; i--)
        {
            nonZeroIndex = size - 1;

            for (int j = size - 1; j >= 0; j--)
            {
                if (matrix[j, i] != 0 && nonZeroIndex < size - 1 &&
                    matrix[j, i] == transformedMatrix[nonZeroIndex + 1, i])
                {
                    transformedMatrix[nonZeroIndex + 1, i] *= 2;
                }
                else if (matrix[j, i] != 0)
                {
                    transformedMatrix[nonZeroIndex--, i] = matrix[j, i];
                }
            }
        }

        return transformedMatrix;
    }
}