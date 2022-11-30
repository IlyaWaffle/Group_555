/*Task №4:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int maxx = 0;
if (a > b)
{
    if (a > c)
    {
        maxx = a;
    }
    else maxx = c;
}
else if (b > c)
{
    maxx = b;
}
else maxx = c;
Console.WriteLine($"{maxx} - Это наибольшее число из трех.");
