// Проверяет массив на палиндром

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void VS(int[] massive)
{
    int i = 0;
    int yes = 0;
    int size = massive.Length - 1;
    while (i < massive.Length)
    {
        if (massive[i] == massive[size])
        {
            yes = yes + 1;
        }
        else break;
        i++;
        size--;
    }
    if (yes == massive.Length) Console.WriteLine(" -> Да");
    else Console.WriteLine(" -> Нет");
}


void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Введите кол-во элементов массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] myArray = new int[count];
FillArray(myArray);
PrintArray(myArray);
VS(myArray);

// int[] ReversArray(int[] massive)
// {
//     int size = 4;
//     int i = 0;
//     while (i < size)
//     {
//         int temp = massive[i];
//         massive[i] = massive[size];
//         massive[size] = temp;
//         size--;
//         i++;
//     }
//     return massive;
// }
Console.ForegroundColor = ConsoleColor.Green;





