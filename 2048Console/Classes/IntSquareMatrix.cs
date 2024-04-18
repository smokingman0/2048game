﻿using System.Numerics;

namespace _2048Console.Classes;

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

    public List<Vector2> ZerosCoordinates()
    {
        var zerosCoordinates = new List<Vector2>();

        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (this[i, j] == 0)
                {
                    zerosCoordinates.Add(new Vector2(i, j));
                }
            }
        }

        return zerosCoordinates;
    }

    public static IntSquareMatrix Zeros(int size)
    {
        return new IntSquareMatrix(size, new int[size, size]);
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
}