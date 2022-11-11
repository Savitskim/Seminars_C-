// Задача 4. Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел



Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 > max) max = number1;
else if (number2 > max) max = number2;
else if (number3 > max) max = number3;
Console.WriteLine($"Максимальное число = {max}");
