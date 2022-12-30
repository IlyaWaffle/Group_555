/*
Задача 62. Напишите программу, которая заполнит
спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
class Spiral
{
    static void DisplayArray(int[,] print)
    {
        for (int i = 0; i < print.GetLength(0); i++)
        {
            for (int j = 0; j < print.GetLength(1); j++)
            {
                if (print[i, j] < 10)
                    Console.Write("{0,2} ", $"0{print[i, j]}");
                else
                {
                    Console.Write("{0,1} ", $"{print[i, j]}");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Задайте размер массива (0 - Выход): ");

            int n;
            if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

            Console.WriteLine();

            int[,] a = new int[n, n];

            int i = 0, j = 0;

            int value = 1;

            while (n != 0)
            {
                int k = 0;
                do { a[i, j++] = value++; } while (++k < n - 1);
                for (k = 0; k < n - 1; k++) a[i++, j] = value++;
                for (k = 0; k < n - 1; k++) a[i, j--] = value++;
                for (k = 0; k < n - 1; k++) a[i--, j] = value++;

                ++i; ++j; n = n < 2 ? 0 : n - 2;
            }

            DisplayArray(a);
            Console.WriteLine();
        }
    }
}