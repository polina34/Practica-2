// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int day = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(Week(day));


int ReadInt(string text) {
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string Week(int a) {

    if (a > 0 && a < 8) {

        if (a == 7 || a == 6) Console.Write( a + " - Выходной");
        
        else {
            Console.Write( a + " - Рабочий ");
        }
    }
    // Если число не из предела.

    else {
        Console.Write("Вы ввели число не из периода (0;7], поэтому не возможно определить");
    }
    return " день.";
}