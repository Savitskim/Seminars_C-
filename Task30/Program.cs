void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2); // диапазон от 0 до 2 при Next(0,2) 2 не включена!!!!!!!!
    }
}
int[] zeroAndOne = new int[8];
FullArray(zeroAndOne);
PrintArray(zeroAndOne);