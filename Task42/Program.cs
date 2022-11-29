// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// void BinaryCode(int num)
// {
//     while(num!=0)
//     {
//         int bincode=num-(num/2)*2;
//         num=num/2;
//         Console.Write($"{bincode} ");
//     }
// }

int[] BinaryCode(int num)
{
    int num2 = num;
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;
    }
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num2 % 2;
        num2 = num2 / 2;
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] massive = BinaryCode(46);
ReverseArray(massive);
PrintArray(massive);
