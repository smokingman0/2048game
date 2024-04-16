using _2048Game._2048Console.Classes;

Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 32, 2, 32 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 4, 4, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 8, 0, 2 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 8, 0, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 8, 0, 0, 8 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 4, 0, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 4, 8, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 0, 16, 16 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 16, 0, 16 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 0, 0, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 2, 0, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 0, 2, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 0, 0, 2 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 4, 2, 8, 2 })));

int[] ShiftRight(int size, int[] array)
{
    int[] newArray = { 0, 0, 0, 0 };
    int nonZeroIndex = size - 1;

    for (int i = size - 1; i >= 0; i--)
    {
        if (array[i] != 0 && nonZeroIndex < size -1 && array[i] == newArray[nonZeroIndex + 1])
        {
            newArray[nonZeroIndex + 1] *= 2;
        }
        else if(array[i] != 0)
        {
            newArray[nonZeroIndex--] = array[i];
        }
    }

    return newArray;
}