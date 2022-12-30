/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] a = new int[4, 5];
int[,] b = new int[4, 4];
int[,] c = new int[a.GetLength(0), b.GetLength(1)];

if (a.GetLength(1) != b.GetLength(0))
{
    Console.Write("Матрицы не равны");
    return;
}

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = new Random().Next(10);
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        b[i, j] = new Random().Next(10);
        Console.Write($"{b[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        for (int r = 0; r < a.GetLength(1); r++)
        {
            c[i, j] += a[i, r] * b[r, j];
        }
    }
}

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        Console.Write($"{c[i, j]} ");
    }
    Console.WriteLine();
}