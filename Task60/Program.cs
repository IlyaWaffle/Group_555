/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] array = new int[2, 2, 2];

int[] numbers = new int[20];
for (int i = 0; i < 20; i++)
{
    numbers[i] = i + 10;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int index = new Random().Next(20);
            while (numbers[index] == 0)
                index = new Random().Next(20);
            array[i, j, k] = numbers[index];
            numbers[index] = 0;
        }
    }

}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        { Console.Write($"{array[i, j, k]} ({i},{j},{k}) "); }
        Console.WriteLine();
    }

}
Console.WriteLine();
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 0)
        Console.WriteLine("Число использовано ");
    if (numbers[i] != 0)
        Console.WriteLine($"Осталось число: {numbers[i]}");
}