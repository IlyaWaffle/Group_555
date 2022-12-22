/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
Задача 47.
*/



void Main(string[] args)
{
    Console.WriteLine("Был вызван метод маин.");
    int m;
    Console.Write("Введите значение М: ");
    int.TryParse(Console.ReadLine(), out m);
    int n;
    Console.Write("Введите значение N: ");
    int.TryParse(Console.ReadLine(), out n);


    double[,] arrayData = new double[m, n];
    int arrayLengtThatM = arrayData.GetLength(0);
    int arrayLengtThatN = arrayData.GetLength(1);

    for (int i = 0; i < arrayLengtThatM; i++)
    {
        for (int j = 0; j < arrayLengtThatN; j++)
        {
            arrayData[i, j] = new Random().NextDouble() * new Random().Next(-10, 10);

            Console.Write($"{Math.Round(arrayData[i, j], 1)} ");
        }
        Console.WriteLine();
    }

}

Main(args);




