/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.WriteLine("Введите число, возводимое в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int A, int B){
    int res = A;
    for(int i = 1; i < B; i++){
        res = res*A;
    }
    return res;
}

if(a<0) a = -a;
int degree = Degree(a, b);
Console.WriteLine($"Число {a} в степени {b} = {degree}");

