// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int num)
{
    int digit = 0;
    while (num != 0)
    {
        num = num / 10;
        digit++;
    }
    return digit == 0 ? 1 : digit;
}

int digitNumber = NumberDigit(number);
Console.WriteLine($"{number} -> {digitNumber}");

