/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
//Я не справился с этой задачей, посмотрел решение.
int userNumber;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out userNumber);
int temp = userNumber;
int summ = 0;
while (temp > 0)
{
    summ += temp % 10;
    temp /= 10;
}
Console.Write($"{userNumber} - > {summ}\n");

//Я пытался решить задачу спомощью массива представит себе что я сладываю числа 
Console.Write("Введите число: ");
string userEnter = Console.ReadLine()!;
int count = 0;
for (int i = 0; i < userEnter.Length; i++)
{

    count = count + userEnter[i];
}
Console.WriteLine(count);