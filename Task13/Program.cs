﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99)  // Если чисо меньше 99 то вывод нет третей цифры.
    Console.Write("Третьей цифры нет.");
else
    if (number > 99 && number < 999)  // Если число больше 99 и меньше 999 то вывод число % 10 (645 -> 5, 742 - > 2, 689 - > 9)
    Console.Write($"{number} - > {number % 10}\n");
else
 if (number > 999 && number < 9999) //  Если число больше 999 и меньше 9999 то вывод число / 10 и % 10 (4321 - > 2, 8541 - > 4, 7590 - > 9)
    Console.Write($"{number} - > {number / 10 % 10}\n");
else
    if (number > 9999 && number < 99999)
    Console.Write($"{number} - > {number / 100 % 10}");  // Если условия выше не подходят выполняем этот число / 100 % 10 (32679 -> 6, 52410 - > 4, 74562 - > 5)
else
    Console.Write("Достигнут предел программы.");