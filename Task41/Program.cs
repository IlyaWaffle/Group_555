/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/

string textPrintStart = "Введите число через пробел и запятую";
Console.Write(textPrintStart.Insert(36, ": "));

char[] singEliments = new char[3] { ' ', ',', '.' };
string[] userEnter = Console.ReadLine()!.Split(singEliments, StringSplitOptions.RemoveEmptyEntries);

int[] array = new int[userEnter.Length];

for (int i = 0; i < array.Length; i++)
    int.TryParse(userEnter[i], out array[i]);

int counter = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if (array[i] > 0)
        counter++;
}

string textPrintFinish = "Постичайте сколько, чисел больше 0, ввёл пользователь.";

string[] textPrint = textPrintFinish.Split(", ");

Console.Write($"\n{textPrint[1]} -> {counter}");