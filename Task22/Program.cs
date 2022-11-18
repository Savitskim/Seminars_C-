// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());
void Square_Table(int number)
{
    int start = 1;
    while (start <= number)
    {
        int square = start * start;
        Console.WriteLine($"{start,4}  {square}");
        start++;
    }
}
if (num < 0) num = -num;
Square_Table(num);
