//task № 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int num_1 = 0, num_2 = 0;
int max = 0, min = 0;

Console.Write($"Введите первое число: ");
string userEnterFirst = Console.ReadLine()!;
num_1 = Convert.ToInt32(userEnterFirst);

Console.Write($"Введите второе число: ");
string userEnterSecond = Console.ReadLine()!;
num_2 = Convert.ToInt32(userEnterSecond);

// решения задачи через if, else
if (num_1 < num_2)
{
    min = num_1;
    max = num_2;
    Console.WriteLine($" Min = {min}");
    Console.WriteLine($" Max = {max}");
}
else
{
    if (num_1 > num_2)
    {
        min = num_2;
        max = num_1;
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
    }
}
