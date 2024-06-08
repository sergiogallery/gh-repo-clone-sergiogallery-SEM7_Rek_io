using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int N = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        if (M < N)
        {
            Console.WriteLine(M);
            if (M + 1 <= N)
            {
                PrintNumbers(M + 1, N);
            }
        }
        else
        {
            Console.WriteLine(M);
            if (M - 1 >= N)
            {
                PrintNumbers(M - 1, N);
            }
        }
    }
}


