/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int M, N;
Console.Write("Ввод:");
int.TryParse(Console.ReadLine(), out M);
Console.Write("Ввод:");
int.TryParse(Console.ReadLine(), out N);
int result = M;
//for (int i = M; i < N; i++)
//{
//  result = result + (i + 1);
//}
//Console.Write(result);
void PrintResult(int count, int stop)
{
    if (count > stop)
    {
        Console.Write($"{result - M}");
        return;
    }
    result = result + count;
    PrintResult(count + 1, stop);
}
PrintResult(M, N);
