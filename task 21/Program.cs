/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите точку хa -> ");
int xa1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ya -> ");
int ya1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку za -> ");
int za1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку хb -> ");
int xb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку yb -> ");
int yb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку zb -> ");
int zb1 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb){
    double xc = (xa - xb)*(xa - xb);
    double yc = (ya - yb)*(ya - yb);
    double zc = (za - zb)*(za - zb);
    double result = Math.Sqrt(xc +yc +zc);
    return result;
}

double res = Distance(xa1, ya1, za1, xb1, yb1, zb1);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);