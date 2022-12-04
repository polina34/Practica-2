// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine($"Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double FindXPoint(double num1, double num2, double num3, double num4)
{
    double x = (-num3 + num1) / (-num2 + num4);
    return x;
}

double FindYPoint(double num1, double num2, double num3, double num4, double result)
{
    double y = num4 * result + num3;
    return y;
}

double xresult = FindXPoint(b1, k1, b2, k2);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({FindXPoint( b1, k1, b2, k2)};{FindYPoint( b1, k1, b2, k2, xresult)})");