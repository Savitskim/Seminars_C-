// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

// Через встроенный функционал
// double Degree(double n1, double n2)
// {
//     return Math.Pow(n1, n2);
// }

// Console.WriteLine("Введите число А:");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В (натуральное):");
// double b = Convert.ToInt32(Console.ReadLine());
// if (b < 0) Console.WriteLine("Число В не является натуральным");
// else Console.WriteLine($"{a}, {b} -> {Degree(a, b)}");


// Через цикл
Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В (натуральное):");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    int count = 1;
    int result = 1;
    while (count <= num2)
    {
        result = result * num1;
        count++;
    }
    return result;
}
if (b < 0) Console.WriteLine("Число В не является натуральным");
else Console.WriteLine($"{a}, {b} -> {Degree(a, b)}");
