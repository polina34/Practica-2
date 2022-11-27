/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num){
    int sum = 0;
    int dig = 0;
    if (num < 0 ) num = num * -1;
    while (num > 0){
        dig = num % 10;
        sum = sum + dig;
        num = num / 10;
    }
    return sum;
}
int sumDigits = SumDigits(n);
Console.WriteLine($"{n} -> {sumDigits}");