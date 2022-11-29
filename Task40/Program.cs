// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

bool Find(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}

bool result = Find(n1, n2, n3);
Console.Write(result ? "Да" : "Нет");