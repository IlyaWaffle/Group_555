/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

//Решение через цикл For
Console.Write("Вветидет число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите его степень: ");
int numB = Convert.ToInt32(Console.ReadLine());
//Создаем переменную для хранения последующие действий 
int temp = 1;
for (int i = 1; i <= numB; i++)
{
    temp = numA * temp;
}
Console.WriteLine($"Степень числа {numA} = {temp}");

Console.WriteLine("================");


//Решение через цикл While
Console.Write("Введите новое число А: ");
int numAtest = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие его степень: ");
int numBtest = Convert.ToInt32(Console.ReadLine());
int index = 0;
int temp2 = 1;
while (index < numBtest)
{
    temp2 = temp2 * numAtest;
    index++;
}
Console.WriteLine($"Степень числа {numAtest} = {temp2}");

Console.Write("===============\n");

// Способ решения через метод
Console.Write("Введите число A: ");
int xA;
int.TryParse(Console.ReadLine(), out xA);
Console.Write("Введите число B: ");
int xB;
int.TryParse(Console.ReadLine(), out xB);
void Calculator()
{
    int temp3 = 1;
    for (int index = 1; index <= xB; index++)
    {
        temp3 = xA * temp3;
    }
    Console.WriteLine($"Степень числа {xA} = {temp3}");
}

Calculator();