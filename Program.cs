//Task № 6 :
/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/
/*4 -> да
-3 -> нет
7 -> нет*/

int num = 0;

Console.Write($"Введите ваше число: ");

string userEnter = Console.ReadLine()!;
num = Convert.ToInt32(userEnter);

if (num % 2 == 0)
{
    Console.WriteLine($"Да, число четное.");
}
else
{
    Console.WriteLine("Нет, число не четное.");
}