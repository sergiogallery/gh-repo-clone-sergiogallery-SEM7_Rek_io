﻿using System;

internal class stR
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение m:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");
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
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
