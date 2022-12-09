// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumDigitNumber(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SumDigitNumber(number / 10);
}
int result = SumDigitNumber(Math.Abs(num));
Console.WriteLine(result);
