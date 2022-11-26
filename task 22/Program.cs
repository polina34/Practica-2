/* Напишите программу, которая принимает на вход число (N) 
и выдвет таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4.
Вывод в виде таблицы
System.Console.WriteLine({num}      {num*num});
1   1
2   4
3   9
4   16
5   25
6   36   */

Console.WriteLine("Введите число N ");
int num = Convert.ToInt32(Console.ReadLine());

void Square(int n){
    for(int i = 0; i <= n; i++){
        Console.WriteLine($"{i} -> {i*i}");
    }
}
Square(num);

/* Второй вариант решения.
int n = -1;
while (n<1){
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if(n<1) Console.WriteLine("Введены неверные данные");
}

void Quarter (int num){
    int count = 1;
    while (count <= num){
        Console.WiteLine($"Число {count} и его квадрат {count*count}");
        count++;
    }
}

Quarter(n); */