void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{ array[i]}");
    }
    Console.WriteLine();
}
// void VS(int[] massive, int[] revers)
// {
//     int yes=0;
//     for(int index=0;index<revers.Length;index++)
//     {
//         if(massive[index] == revers[index])
//         {
//             yes=yes+1;
//         }
//     }
//     if(yes==revers.Length) Console.WriteLine("Да");
//     else Console.WriteLine("Нет");
//     Console.WriteLine(yes);
// }
// void ReversArray(int[] massive)
// {
//     int size=massive.Length-1;
//     int i=0;
//     while(i>size)
//     {
//         int temp=massive[i];
//         massive[i]=massive[size];
//         massive[size]=temp;
//         size=size-1;
//         i++;
//     }
// }
// int[] myArray2 = new int[5];
// int[] myArray = new int[5];
// for (int i = 0; i<myArray.Length;i++)
// {
//     Console.Write($"Введите элемент массива под индексом {i}: ");
//     myArray[i] = Convert.ToInt32(Console.ReadLine());
//     myArray2[i]=myArray[i];
// }
