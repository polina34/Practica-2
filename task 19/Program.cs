/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да*/


Console.WriteLine( "Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b1 = 0;


int Palindrom(int temp, int b = 0){
if ((temp > 9999) && (temp < 100000)){
    while (temp != 0){
          b = b * 10 + temp % 10; //Переворачиваем число по цифрам
          temp /= 10;             //Отбрасываем последнюю цифру
    }
 
    if (a == b) Console.Write($"{a} -> да");
    else Console.Write($"{a} -> нет");
}   
else Console.Write("Вы ввели не пятизначное число");
return a;
}

int result = Palindrom(a, b1);


