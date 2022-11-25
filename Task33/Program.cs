//  Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.Write("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] firstArray = CreateArrayRndInt(4, -5, 6);
PrintArray(firstArray);
Console.Write($" -> ");
bool FindNumber(int[] arr, int number)
{
    bool IsFalse = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) 
        {
            IsFalse = true;
            break;
        }
    }
    return IsFalse;
}
bool result = FindNumber(firstArray, find);
Console.Write(result ? "Да" : "Нет");