// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

bool Palindrome(int num)
{
    return num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10;
}

bool IsTrue = true;
while (IsTrue)
{
    if (number < 100000 && number > 9999)
    {
        bool result = Palindrome(number);
        Console.Write($"{number} -> ");
        Console.WriteLine(result ? "да" : "нет");
        IsTrue = false;
    }
    else
    {
        Console.WriteLine("Число некорректно!");
        Console.Write("Введите пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
}
