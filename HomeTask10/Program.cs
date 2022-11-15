// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}
bool IsTrue = true;
while (IsTrue)
{
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 1000 && number > 100)
    {
        int result = SecondDigit(number);
        Console.WriteLine($"Вторая цифра числа {result}");
        IsTrue = false;
    }
}
