using System;

class Program
{
    static void Main()
    {
        int m = 2;
        int n = 3;

        int result = Ackermann(m, n);
        Console.WriteLine($"Функция Аккермана A({m}, {n}) = {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            throw new ArgumentOutOfRangeException("m и n должны быть неотрицательными числами.");
        }
    }

}