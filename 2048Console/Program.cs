using _2048Game._2048Console.Classes;

Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 2, 2, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 4, 4, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 8, 0, 2 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 0, 8, 0, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 8, 0, 0, 8 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 4, 0, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 4, 8, 0 })));
Console.WriteLine(string.Join(", ", ShiftRight(4, new int[] { 2, 0, 16, 16 })));

int[] ShiftRight(int size, int[] array)
{
    for (int i = 0; i < size - 1; i++)
    {
        if (array[i] != 0 && array[i + 1] == 0)
        {
            array[i + 1] = array[i];
            array[i] = 0;
        }

        if (array[i] == array[i + 1])
        {
            array[i + 1] *= 2;
            array[i] = 0;
        }
    }

    return array;
}