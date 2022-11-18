// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти чтобы узнать диапазон - ");
string quarter = Console.ReadLine();


string Quarter(string number)
{
    if (number == "1") return "Диапазон: x>0 y>0";
    if (number == "2") return "Диапазон: x<0 y>0";
    if (number == "3") return "Диапазон: x<0 y<0";
    if (number == "4") return "Диапазон: x>0 y<0";
    return "Введены некорректные данные";
}
string result = Quarter(quarter);
Console.WriteLine(result);

