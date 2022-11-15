// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());


bool MultiplicityToDigit(int arg, int arg1, int arg2)
{
    return arg % arg1 == 0 && arg % arg2 == 0;
}

bool result = MultiplicityToDigit(number,7,23);
Console.Write($"{number} - > ");
Console.Write(result ? "Да" : "Нет");
