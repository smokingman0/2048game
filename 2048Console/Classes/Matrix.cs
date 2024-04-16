namespace _2048Game._2048Console.Classes;

public class IntSquareMatrix
{
    public int Size { get; private set; }
    private int[,] _Elements;

    public int this[int i, int j]
    {
        get
        {
            if (i < 0 || i >= Size || j < 0 || j >= Size)
                throw new IndexOutOfRangeException("Index out of range");

            return _Elements[i, j];
        }

        set
        {
            if (i < 0 || i >= Size || j < 0 || j >= Size)
                throw new IndexOutOfRangeException("Index out of range");

            _Elements[i, j] = value;
        }
    }

    public IntSquareMatrix(int size, int[,] elements)
    {
        Size = size;
        _Elements = elements;
    }

    public IntSquareMatrix Transpose()
    {
        var transpose = Zeros(Size);

        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                transpose[i, j] = this[j, i];
            }
        }

        return transpose;
    }

    public static IntSquareMatrix Zeros(int size)
    {
        var elements = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                elements[i, j] = 0;
            }
        }

        return new IntSquareMatrix(size, elements);
    }

    public override string ToString()
    {
        var matrixString = "";

        for (int i = 0; i < Size; i++)
        {
            matrixString += "\n";

            for (int j = 0; j < Size; j++)
            {
                matrixString += $"{this[i, j]} ";
            }
        }

        return matrixString;
    }

    public static IntSquareMatrix Multiply(IntSquareMatrix A, IntSquareMatrix B)
    {
        if (A.Size != B.Size)
        {
            throw new ArithmeticException(
                "Square matrixes A and B can't be multiplied, because their sizes are not equal");
        }

        var productMatrixSize = A.Size;
        var product = Zeros(productMatrixSize);

        for (int i = 0; i < productMatrixSize; i++)
        {
            for (int j = 0; j < productMatrixSize; j++)
            {
                product[i, j] += A[i, j] * B[j, i];
            }
        }

        return product;
    }
}