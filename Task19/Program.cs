/*Задача 21
Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53*/

int A_x, A_y, A_z, B_x, B_y, B_z;  // Задаем переменные по осям X Y Z

Console.Write($"Введите координату x в точке A: ");
int.TryParse(Console.ReadLine(), out A_x);
Console.Write($"Введите координату y в точке А: ");
int.TryParse(Console.ReadLine(), out A_y);
Console.Write($"Введите координату z в точке A: ");
int.TryParse(Console.ReadLine(), out A_z);
Console.Write($"Введите координату х в точке В: ");
int.TryParse(Console.ReadLine(), out B_x);
Console.Write($"Введите координату y в точке В: ");
int.TryParse(Console.ReadLine(), out B_y);
Console.Write($"Введите координату z в точке B: ");
int.TryParse(Console.ReadLine(), out B_z);

int x = (B_x - A_x) * (B_x - A_x);
int y = (B_y - A_y) * (B_y - A_y);
int z = (B_z - A_z) * (B_z - A_z);
int xyz = x + y + z;
double ans = Math.Round(Math.Sqrt(xyz), 2);  // Round(Double) Округляет значение с плавающей запятой двойной точности до ближайшего целого значения; значения посередине округляются до ближайшего четного числа.
                                             //Math.Sqrt Возвращает квадратный корень из указанного числа.
Console.WriteLine("Операция успешна!\n ===============");
Console.Write($"Расстояние между точками A и В = {ans}");