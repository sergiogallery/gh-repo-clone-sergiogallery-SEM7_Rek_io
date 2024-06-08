using System;

class Prog
{
    static void PrintArrayInReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayInReverse(array, index - 1);
        }
    }

    static void Main()
    {
        int[] array = {1, 2, 3, 4, 5}; // Задайте свой массив здесь
        PrintArrayInReverse(array, array.Length - 1);
    }
}
