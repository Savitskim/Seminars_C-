﻿// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int siz, int min, int max)
{
    int[] array = new int[siz];
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
void ReverseArray(int[] arr)
{
for (int i = 0; i < arr.Length/2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length-1-i];
    arr[arr.Length-1-i]=temp;
}
}
int[] array = CreateArrayRndInt(6,0,100);
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
PrintArray(array);