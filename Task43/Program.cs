﻿/*
Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

static void Program()
{
    double b1 = 2;
    double k1 = 5;

    double b2 = 4;
    double k2 = 9;

    double x;
    double y;
    
    void ProgramMath()
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}: \nresult = ( x {x}; y {y})");
    }
    ProgramMath();
}
Program();

