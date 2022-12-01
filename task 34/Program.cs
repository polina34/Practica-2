/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */


int size = ReadInt("Введите размерность массива: ");
int[] numbers = new int[size];
int result = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{ 
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( array[i]+" ");
    }
    Console.WriteLine("]");
}


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}

Console.WriteLine($" -> {result} ");