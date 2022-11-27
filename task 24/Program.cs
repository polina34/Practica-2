/* Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 
----------
default означает что значение переменной еще не определено
например int res = default;
*/

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num){
    int sum = 0;
    for (int i = 1; i <= num; i++){
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

if (number > 0){
    int sumNumbers = SumNumbers(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
}

else Console.WriteLine("Требуется ввести натуральное число.");

/* Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num){       - сигнатура метода(там где содержатся параметры)
    int sum = 0;
    for (int i = 0; i <= num; i++){
        sum = sum + i;
    }
    return sum;
}

int sumDigits = SumDigits(number);
console.WriteLine($"Сумма чисел от 1 до {A} = {sumDigits}");*/