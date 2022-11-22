// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число (A): ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
    {
        product = product * i;
    }
    return product;
}
if (number > 0) Console.WriteLine($"{number} -> {Factorial(number)}");
else Console.WriteLine("Введите натуральное число");
