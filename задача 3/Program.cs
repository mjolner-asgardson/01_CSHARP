using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 12, 4, 4, 100, 1008, 2 };
        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
}