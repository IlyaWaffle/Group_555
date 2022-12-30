/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/
Console.Write("Ввод: ");
int N; int.TryParse(Console.ReadLine(), out N);


void PrintNumbers(int number, int stop)
{

    if (number <= stop)
    {
        Console.Write($"{number}.");
        return;
    }
    Console.Write($"{number}, ");
    Thread.Sleep(500);
    PrintNumbers(number - 1, stop);

}

PrintNumbers(N, 1);