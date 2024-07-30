using System;

class Program
{
    static void Main()
    {
        int M = -15;
        int N = 29;

        if (M <= 0)
        {
            M = 1;
        }

        PrintNumbersInRange(M, N);
    }
    static void PrintNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNumbersInRange(start + 1, end);
        }
    }
}