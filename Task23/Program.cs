﻿/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
// в данном коде я еще рассматриваю метод TryParse
Console.Write("Введите число чтобы увидеть таблицу кубов: ");
string str = Console.ReadLine();  // Подругому не понял как записать эту чать кода.

int n;
int.TryParse(str, out n); // Метот Конвертации Трайпарс, переменная str делает перевод в переменную n.
bool result = int.TryParse(str, out n);

if (result)  // Эта часть кода проверяет выполняется ли Конвертация строки. Если выражение True все работает.
{
    Console.WriteLine("Число допустимо для работы.");
    Console.WriteLine("Конвертация прошла успешно.\nПрограмма работает дальше.");
    for (int i = 1; i < n + 1; i++)  // i увеличеватеся и умножается на себя, пока значение ай не станет FALSE I < N.
    {
        Console.Write($"Куб числа от 1 до {n} - > {i * i * i} это {i} * {i} * {i}\n");
    }
}
else // Это часть кода сработает если пользователь введет строковое значение тоесть букву или же букву с цифрой.
{
    Console.Write("Не удалось конвертировать!\nВы ввели букву или цифру с буквой, введти еще раз только цифру.");
}

