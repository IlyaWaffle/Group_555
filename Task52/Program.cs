/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/


double[,] array = new double[3, 4];

int arrayLengthFirst = array.GetLength(0);
int arrayLengthSecond = array.GetLength(1);

for (int i = 0; i < arrayLengthFirst; i++)
{
    for (int j = 0; j < arrayLengthSecond; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arrayLengthFirst; i++)
{
    double result = 0;
    for (int j = 0; j < arrayLengthSecond; j++)
    {
        result = (array[i, j] + array[i + 1, j] + array[i + 2, j]) / 2;
        Console.Write($"{result} ");

    }
    if (i == 0)
    {
        break;
    }

}