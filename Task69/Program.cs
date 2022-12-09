// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число степени: ");
int power = Convert.ToInt32(Console.ReadLine());
int NumberPow(int number, int pow)
{
    if (pow == 0) return 1;
    return number * NumberPow(number, pow - 1);
}
int result = NumberPow(num, power);
Console.WriteLine(result);