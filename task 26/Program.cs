/* Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5      */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumLenght(int num){
    int n = 1;
    for(int i = 0; i <10; i++){
        num = num / 10;
        if (num != 0)n++;
        else break;

    }
    return n;
}

int numLength = NumLenght(num: number);
Console.WriteLine(numLength);

/* Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num){
    int count = 0;
    int dig = default;
    while(num > 0){
        dig = num / 10;
        num = dig;
        count++;
    }
    return count;
}

int result = Digits(number);
Console.WriteLine($"Количество цифр в числе {number} ---> {result}");

*/
