// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число (A): ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int NumberSequenceSumm(int num)
{
    int summ = 0;
    for (int i = 1; i <= num; i++)
    {
        summ = summ + i;
    }
    return summ;
}
Console.WriteLine($"{number} -> {NumberSequenceSumm(number)}");
