/* Напишите программу, которая ринимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
А(3,6);B(2,1) -> 5,09
A(7,-5);B(1,-1) -> 7,21  */

/*Чтобы определить корень:
int n = 12345;
double res = Math.Sqrt(n);

Как сделать округление:

double n = 5,09994349349;
double nRound = Math.Round(n1, 2, MidpointRounding.ToZero);

Console.WriteLine (nRound);*/

Console.Write("Введите точку хa -> ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ya -> ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку хb -> ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку yb -> ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int xb, int yb){
    double xc = (xa - xb)*(xa - xb);
    double yc = (ya - yb)*(ya - yb);
    double result = Math.Sqrt(xc +yc);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);
