// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
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
Console.WriteLine("Введите кол-во чисел: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] myArray = new int[count];
FillArray(myArray);
int result = CountPositiveNumbers(myArray);
PrintArray(myArray);
Console.WriteLine($" -> {result}");


