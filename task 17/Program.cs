﻿/*Напишите программу, которая 
1.принимает на вход координаты точки (Х и Y), 
2.причем X неравен 0 и Y неравен 0 и 
3.выдает номер четверти плоскости, в которой находится эта точка.*/

Console.WriteLine("Введите координаты точки");
Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0
    ? $"Указанные координаты соответствуют четверти -> {quarter}"
    : "Введены некорректные кординаты";

Console.WriteLine(result);