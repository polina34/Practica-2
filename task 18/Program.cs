/*Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти(x и y).*/

Console.Write("Укажите номер четверти: ");
string quarter = Console.ReadLine();

string Range(string quarter0){
    if (quarter0 == "1") return "x > 0 и y > 0";
    if (quarter0 == "2") return "x < 0 и y > 0";
    if (quarter0 == "3") return "x < 0 и y < 0";
    if (quarter0 == "4") return "x > 0 и y < 0";
    return "Введен некорректный диапазон";
}
string range = Range(quarter);

Console.WriteLine(range);

