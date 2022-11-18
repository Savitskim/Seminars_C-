// Задача 23
// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.Write("Введите число -> ");
int n = Convert.ToInt32(Console.ReadLine());
void CubeTable(int number)
{
    int start = 1;
    while (start <= number)
    {
        double cube = Math.Pow(start, 3);
        Console.WriteLine($"{start,3} | {cube}");
        start++;
    }
}
Console.WriteLine($"{n} -> ");
CubeTable(n);
